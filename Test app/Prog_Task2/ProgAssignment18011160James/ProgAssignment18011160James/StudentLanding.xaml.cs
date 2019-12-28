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
using System.Windows.Shapes;
using MyDLL;

namespace ProgAssignment18011160James
{
    /// <summary>
    /// Interaction logic for StudentLanding.xaml
    /// </summary>
    public partial class StudentLanding : UserControl
    {
        //creating lists and variables
        LandingStrip landingStrip;
        List<TestInfo> tests;
        List<MarkInfo> marks;
        Student person;
        int correctmark = 0;
        int counter= 0;
        public static string TestSelected { get; set; }
        public StudentLanding(LandingStrip landingStrip)
        {
            InitializeComponent();
            //instations
            this.landingStrip = landingStrip;
            tests = new List<TestInfo>();
            marks = new List<MarkInfo>();
            person = new Student(landingStrip);

        }

        private void BTStartTest_Click(object sender, RoutedEventArgs e)
        {
            //changes the usercontrol with method from another form
            landingStrip.displaytest();
            MessageBox.Show("Rules:"+"\n1)Select the test you want to do"+"\n2)From the side there will be questions."+"\n3)Select your question, then select your answer by clicking the circle for which you choose.Only select one."+"\n4)Once you have selected a answer, click submit, then move on to the next question. if it has been doen before it will be removed");

        }

        private void BTCheckMarks_Click(object sender, RoutedEventArgs e)
        {
            //making variables and filling lists
            int mark;
            string id = MainWindow.PersonID;
            marks = Methods.fillMarksForStudent(id);
            DgStudentMarksDisplay.ItemsSource = marks;
            //looping list
            foreach (MarkInfo m in marks)
            {
                //checking if they are right
                if (m.TheirAnswer == m.ActualAnswer)
                {
                    correctmark++;
                }
                else
                {
                    counter++;
                }

                
            }
            if (counter == 0)
            {
                //saying they got nothing wrong
                DLL.mark();

            }
            else
            {
                //calculating there mark and showing it.
                mark = correctmark/counter*100;
                MessageBox.Show("Your mark is " + mark +"%");
            }
        }
    }
}
