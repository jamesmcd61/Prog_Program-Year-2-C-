using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;
using MyDLL;

namespace ProgAssignment18011160James
{
    /// <summary>
    /// Interaction logic for Student.xaml
    /// </summary>
    public partial class Student : UserControl
    {
        //creating lists and variables that i will need
        Methods question;
        List<MarkInfo> marks;
        List<TestInfo> test;
        LandingStrip landingStrip;
        char answer;
        string Test;
        string ActualAnswer;
        string TheirAnswer;
        string id;
        string q;
        bool isthere = false;

        public Student(LandingStrip landingStrip)
        {
            InitializeComponent();
            //instations
            this.landingStrip = landingStrip;
            question = new Methods();
            marks = new List<MarkInfo>();
            test = new List<TestInfo>();
            addAvaiableTests();


        }
        private void LBQuestions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (isthere == false)
            {
                //assigning variable
                string questionslected = LBQuestions.SelectedItem.ToString();
                //filling list
                test = Methods.fillTest();
                //looping through test
                foreach (TestInfo t in test)
                {
                    //assigning variable
                    string quest = "Questions" + t.id;
                    //checking if the questions are correct and then adding the corrisponding info to that question to buttons
                    if (questionslected.Equals(quest))
                    {
                        //adding info to radio buttons
                        LbQuestion.Content = t.Question;
                        RBAnswerA.Content = t.AnswerA;
                        RBAnswerB.Content = t.AnswerA;
                        RBAnswerC.Content = t.AnswerC;
                        RBAnswerD.Content = t.AnswerD;
                    }
                }
            }
        }

        private void BtSubmit_Click(object sender, RoutedEventArgs e)
        {
            //filling list
            test = Methods.fillTest();
            //assigning variable
            string questionselected = LBQuestions.SelectedItem.ToString();
            //checking what they answered
            if ((bool)RBAnswerA.IsChecked == true)
            {
                answer = 'A';
            }
            if ((bool)RBAnswerB.IsChecked == true)
            {
                answer = 'B';
            }
            if ((bool)RBAnswerC.IsChecked == true)
            {
                answer = 'C';
            }
            if ((bool)RBAnswerD.IsChecked == true)
            {
                answer = 'D';
            }
            //looping through list
            foreach (TestInfo b in test)
            {
                //checking if the questions are the same
                if(questionselected == ("Questions" + b.id.ToString()))
                {   
                    //chekcing is the answer they answered was right or wrong             
                    if (answer == b.ActualAnswer.ToCharArray()[0])
                    {
                        //adding data to variables
                        Test = b.Test.ToString();
                        ActualAnswer = b.ActualAnswer.ToString();
                        TheirAnswer = answer.ToString();
                        id = b.id.ToString();
                        //printing that they where right if that questioin had not been doen before
                        if (isthere == true)
                        {
                            DLL.correctanswer();
                        }
                    }
                    else
                    {
                        //adding data to variables
                        Test = b.Test.ToString();
                        ActualAnswer = b.ActualAnswer.ToString();
                        TheirAnswer = answer.ToString();
                        id = b.id.ToString();
                        //printing that they where wrong if that questioin had not been doen before
                        if (isthere == true)
                        {
                            DLL.Wronganswer();
                        }
                    }
                  
                }
            }
            //adding answers and other info to objects
            MarkInfo m = new MarkInfo();
            m.Test = Test;
            m.ActualAnswer = ActualAnswer;
            m.TheirAnswer = TheirAnswer;
            m.Question = "Question" + id;
            m.StudentId = MainWindow.PersonID;
            //filling list
            marks = Methods.fillMarks();
            //looping through list
            foreach (var h in marks)
            {
                //checking is the person has answered this question before
                if (h.StudentId == MainWindow.PersonID)
                { //checking iff match
                    if (h.Question == "Question" + id)
                    {
                        isthere = true;
                    }
                }

            }
            if (isthere == true)
            {
                //saying that they have answered that question before
                LBQuestions.Items.Remove(LBQuestions.SelectedItem);
                LBQuestions.SelectedIndex =LBQuestions.SelectedIndex + 1;
                //print out
                DLL.alreadyanswered();
                isthere = false;
            }
            else
            {
                //saves info to DB
                Methods.SaveMark(m);

            }
            
        }
        public void addAvaiableTests()
        {
            //filling list
            test = Methods.fillTest();
            //looping through list
            foreach (TestInfo t in test)
            { //checkinhg if ive added it allready
                if (!CBTest.Items.Contains(t.Test))
                {
                    //adding to combo box
                    CBTest.Items.Add(t.Test);
                }
            }

        }
        private void CBTest_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //filling list
            test = Methods.fillQuestions(CBTest.SelectedItem.ToString());
            LBQuestions.Items.Clear();

            //looping through list
            foreach (TestInfo n in test)
            {
                //adding to list box
                q = "Questions" + n.id;
                    LBQuestions.Items.Add(q);
            }

        }        
    }
}
