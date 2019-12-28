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

namespace ProgAssignment18011160James
{
    /// <summary>
    /// Interaction logic for LandingStrip.xaml
    /// </summary>
    public partial class LandingStrip : Window
    {
        //making links to other usercontrols
        StudentLanding land;
        Student student;
        Admin admin;
        TeacherLanding teacher;
        Teacher teacher2;
        TeacherTest teacher3;
        public LandingStrip()
        {
            InitializeComponent();
            //istantiating to this form
            land = new StudentLanding(this);
            student = new Student(this);
            admin = new Admin();
            teacher = new TeacherLanding(this);
            teacher2 = new Teacher(this);
            teacher3 = new TeacherTest(this);

        }

        public void displayUserView(string userType)
        {
            //switch to see who the user is that loged in
            switch(userType)
            {
                case "Admin":
                    //changing the panel to the user that login
                    PnShow.Children.Clear();
                    PnShow.Children.Add(admin);
                    LblPerson.Content="Admin";
                    BtBack.Visibility = Visibility.Hidden;
                    break;
                case "Teacher":
                    //changing the panel to the user that login
                    PnShow.Children.Clear();
                    PnShow.Children.Add(teacher);
                    LblPerson.Content="Teacher";
                    BtBack.Visibility = Visibility.Hidden;
                    break;
                case "Student":
                    //changing the panel to the user that login
                    PnShow.Children.Clear();
                    PnShow.Children.Add(land);
                    LblPerson.Content="Student";
                    BtBack.Visibility = Visibility.Hidden; 
                    break;
            }
            Show();
        }
        public void displaytest()
        {
            //method for when the button on the usercontrol is clicked to change the panel now to another usercontrol
            PnShow.Children.Clear();
            PnShow.Children.Add(student);
            LblPerson.Content = "Student";
            BtBack.Visibility = Visibility.Visible;
        }
        public void displayCreateTest()
        {
            //method for when the button on the usercontrol is clicked to change the panel now to another usercontrol
            PnShow.Children.Clear();
            PnShow.Children.Add(teacher2);
            LblPerson.Content = "Teacher";
            BtBack.Visibility = Visibility.Visible;
        }
        public void displayTest()
        {
            //method for when the button on the usercontrol is clicked to change the panel now to another usercontrol
            PnShow.Children.Clear();
            PnShow.Children.Add(teacher3);
            LblPerson.Content = "Teacher";
            BtBack.Visibility = Visibility.Visible;
        }



        private void BtLogOut_Click(object sender, RoutedEventArgs e)
        {
            //to go back to login
            MainWindow log = new MainWindow();
            this.Hide();
            log.Show();
        }

        private void BtBack_Click(object sender, RoutedEventArgs e)
        {
            //giving the back button to come back to there previous control panel
            if (LblPerson.Content.ToString() == "Teacher")
            {
                PnShow.Children.Clear();
                PnShow.Children.Add(teacher);
                BtBack.Visibility = Visibility.Hidden;

            }
            //giving the back button to come back to there previous control panel
            if (LblPerson.Content.ToString() == "Student")
            {
                PnShow.Children.Clear();
                PnShow.Children.Add(land);

                BtBack.Visibility = Visibility.Hidden;
            }
            
        }
    }
}
