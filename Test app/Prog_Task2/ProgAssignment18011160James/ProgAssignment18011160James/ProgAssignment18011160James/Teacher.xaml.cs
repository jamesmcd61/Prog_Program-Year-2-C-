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
    /// Interaction logic for Teacher.xaml
    /// </summary>
    public partial class Teacher : UserControl
    {
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

            TestInfo I = new TestInfo();
            I.Question = TBQuestion.Text.ToString();
            I.AnswerA = TBAnswerA.Text.ToString();
            I.AnswerB = TBAnswerB.Text.ToString();
            I.AnswerC = TBAnswerC.Text.ToString();
            I.AnswerD = TBAnswerD.Text.ToString();
            I.ActualAnswer = actualAnswer.ToString();
            I.Test = TBTestNumber.Text.ToString();

            saved = Methods.fillQuestions();

            foreach (var d in saved)
            {
                if (d.Question == I.Question.ToString())
                {
                    isthere = true;
                }

            }
            if (isthere == true)
            {
                MessageBox.Show("You have made that question already for this Test");
            }
            else
            {
                //saves info to DB

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
            TBQuestion.Clear();
            TBAnswerA.Clear();
            TBAnswerB.Clear();
            TBAnswerC.Clear();
            TBAnswerD.Clear();
            TBTestNumber.Clear();
        }
    }
    }

