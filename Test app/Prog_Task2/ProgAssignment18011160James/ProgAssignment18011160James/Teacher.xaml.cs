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
using MyDLL;
namespace ProgAssignment18011160James
{
    /// <summary>
    /// Interaction logic for Teacher.xaml
    /// </summary>
    public partial class Teacher : UserControl
    {
        //making lists and connecting to other forms
        Methods con = new Methods();
        List<TestInfo> saved = new List<TestInfo>();
        LandingStrip landingStrip;

        Boolean isthere = false;
        string actualAnswer;
        public Teacher(LandingStrip landingStrip)
        {
            InitializeComponent();
            this.landingStrip = landingStrip;
        }

        private void BTSubmit_Click(object sender, RoutedEventArgs e)
        {
            //checking what they checked for the real answer
            if ((bool)CbAnswerA.IsChecked ==true)
            {
              actualAnswer = "A";
            }           
            if ((bool)CbAnswerB.IsChecked == true)
            {
                actualAnswer = "B";
            }
             
            if ((bool)CbAnswerC.IsChecked == true)
            {
                actualAnswer = "C";
            }

            if ((bool)CbAnswerD.IsChecked == true)
            {
                actualAnswer = "D";
            }
            //making connection to objects and assigning them
            TestInfo I = new TestInfo();
            I.Question = TBQuestion.Text.ToString();
            I.AnswerA = TBAnswerA.Text.ToString();
            I.AnswerB = TBAnswerB.Text.ToString();
            I.AnswerC = TBAnswerC.Text.ToString();
            I.AnswerD = TBAnswerD.Text.ToString();
            I.ActualAnswer = actualAnswer.ToString();
            I.Test = TBTestNumber.Text.ToString();
            //filling list
            saved = Methods.fillTest();
            //looping through list
            foreach (var d in saved)
            {
                //checking if they have made that question before
                if (d.Question == I.Question.ToString())
                {
                    isthere = true;
                }

            }
            if (isthere == true)
            {
                //telling them they have made that question before
                DLL.existingQuestion();
            }
            else
            {
                //saves info to DB
                //saving the info into db
                Methods.SaveInfo(I);
               
            }
            //message to say what you entered
            MessageBox.Show("You Submitted\n" +
                "\nQuestion: " + I.Question +
                "\n:AnswerA " + I.AnswerA +
                "\nAnswerB: " + I.AnswerB +
                "\nAnswerC: " + I.AnswerC +
                "\nAnswerD: " + I.AnswerD +
                "\nActualAnswer: " + I.ActualAnswer +
                "\nOn Test: " + I.Test);
            //clears for the text boxes and buttons
            TBQuestion.Clear();
            TBAnswerA.Clear();
            TBAnswerB.Clear();
            TBAnswerC.Clear();
            TBAnswerD.Clear();
            TBTestNumber.Clear();
            CbAnswerA.IsChecked = false;
            CbAnswerB.IsChecked = false;
            CbAnswerC.IsChecked = false;
            CbAnswerD.IsChecked = false;

        }
        //clears for then you select an item
        private void TBQuestion_GotFocus(object sender, RoutedEventArgs e)
        {
            TBQuestion.Clear();
        }
        private void TBAnswerA_GotFocus(object sender, RoutedEventArgs e)
        {
            TBAnswerA.Clear();
        }
        private void TBAnswerB_GotFocus(object sender, RoutedEventArgs e)
        {
            TBAnswerB.Clear();
        }
        private void TBAnswerC_GotFocus(object sender, RoutedEventArgs e)
        {
            TBAnswerC.Clear();
        }
        private void TBAnswerD_GotFocus(object sender, RoutedEventArgs e)
        {
            TBAnswerD.Clear();
        }
        private void TBTestNumber_GotFocus(object sender, RoutedEventArgs e)
        {
            //to make sure you type it right.
            TBTestNumber.Clear();
            TBTestNumber.Text = "Test";
        }

    }
    }

