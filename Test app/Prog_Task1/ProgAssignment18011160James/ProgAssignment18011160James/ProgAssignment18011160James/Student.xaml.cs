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

namespace ProgAssignment18011160James
{
    /// <summary>
    /// Interaction logic for Student.xaml
    /// </summary>
    public partial class Student : UserControl
    {
        Methods question;
        List<TestInfo> printQ;
        List<TestInfo> test;
        LandingStrip landingStrip;
        char answer;
        string questions;
        string Test;
        string ActualAnswer;
        string theiranswer;
        string id;
        public Student(LandingStrip landingStrip)
        {
            InitializeComponent();
            this.landingStrip = landingStrip;
            question = new Methods();
            printQ = new List<TestInfo>();
            test = new List<TestInfo>();
            addQuestions();

        }
        private void LBQuestions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string questionslected = LBQuestions.SelectedItem.ToString();
           

            foreach (TestInfo t in test)
            {
                if (questionslected == "Question "+t.id.ToString())
                {
                    LbQuestion.Content = t.Question;
                    RBAnswerA.Content = t.AnswerA;
                    RBAnswerB.Content = t.AnswerA;
                    RBAnswerC.Content = t.AnswerC;
                    RBAnswerD.Content = t.AnswerD;
                }
            }
        }
        public void addQuestions()
        {
            test = Methods.fillTest();
            foreach (TestInfo n in test)
            {
                LBQuestions.Items.Add("Question "+n.id);
            }
        }
        private void BtSubmit_Click(object sender, RoutedEventArgs e)
        {
            test = Methods.fillTest();
            string questionselected = LBQuestions.SelectedItem.ToString();
   
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

            foreach (TestInfo b in test)
            {
                if(questionselected == ("Question " + b.id.ToString()))
                {                
                    if (answer == b.ActualAnswer.ToCharArray()[0])
                    {
                        questions = b.Question.ToString();
                        Test = b.Test.ToString();
                        ActualAnswer = b.ActualAnswer.ToString();
                        TheirAnswer = answer.ToString();
                        id = b.id.ToString();
                        MessageBox.Show("You are Correct,Please go to the next Quesiton");
                    }
                    else
                    {
                        questions = b.Question.ToString();
                        Test = b.Test.ToString();
                        ActualAnswer = b.ActualAnswer.ToString();
                        TheirAnswer = answer.ToString();
                        id = b.id.ToString();
                        MessageBox.Show("You where Wrong,Please go to the next Question");
                    }
                  
                }
            }

            MessageBox.Show(Test+" "+ActualAnswer+" "+TheirAnswer+" " + "Question"+id);

        }
    }
}
