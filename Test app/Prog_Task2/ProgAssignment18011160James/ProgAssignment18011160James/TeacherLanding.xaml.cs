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
    /// Interaction logic for TeacherLanding.xaml
    /// </summary>
    public partial class TeacherLanding : UserControl
    {
        //making lists
        LandingStrip landingStrip;
        List<StudentInfo> user;
        List<MarkInfo> marks;

        public TeacherLanding(LandingStrip landingStrip)
        {
            InitializeComponent();
            this.landingStrip = landingStrip;
            user = new List<StudentInfo>();
            marks = new List<MarkInfo>();

        }
    

        private void BtCreateTest_Click(object sender, RoutedEventArgs e)
        {
            //taking to antoher usercontrol
            landingStrip.displayCreateTest();
        }

        private void BtCheckStudents_Click(object sender, RoutedEventArgs e)
        {
            //filling list
            user = Methods.fillStudent();
            //adding contents of list to datagrid
            DgStudents.ItemsSource = null;
            DgStudents.Items.Refresh();
            DgStudents.ItemsSource = user;
           
        }

        private void btCheckMarks_Click(object sender, RoutedEventArgs e)
        {
            //filling list
            marks = Methods.fillMarks();
            //adding contents of list to datagrid
            DgStudents.ItemsSource = null;
            DgStudents.Items.Refresh();
            DgStudents.ItemsSource = marks;
        }

        private void BtCheckTest_Click(object sender, RoutedEventArgs e)
        {
            //chnaging screen           
            landingStrip.displayTest();
        }
    }
}
