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
        StudentLanding land;
        Student student;
        Admin admin;
        TeacherLanding teacher;
        Teacher teacher2;
        public LandingStrip()
        {
            InitializeComponent();
            land = new StudentLanding(this);
            student = new Student(this);
            admin = new Admin();
            teacher = new TeacherLanding(this);
            teacher2 = new Teacher(this);         
            
        }

        public void displayUserView(string userType)
        {
            switch(userType)
            {
                case "Admin":
                    PnShow.Children.Clear();
                    PnShow.Children.Add(admin);
                    LblPerson.Content="Admin";
                    break;
                case "Teacher":
                    PnShow.Children.Clear();
                    PnShow.Children.Add(teacher);
                    LblPerson.Content="Teacher";
                    break;
                case "Student":
                    PnShow.Children.Clear();
                    PnShow.Children.Add(land);
                    LblPerson.Content="Student";
                    break;
            }
            Show();
        }
        public void displaytest()
        {
            PnShow.Children.Clear();
            PnShow.Children.Add(student);
            LblPerson.Content = "Student";
        }
        public void displayCreateTest()
        {
            PnShow.Children.Clear();
            PnShow.Children.Add(teacher2);
            LblPerson.Content = "Teacher";
        }



        private void BtLogOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow log = new MainWindow();
            this.Hide();
            log.Show();
        }



    }
}
