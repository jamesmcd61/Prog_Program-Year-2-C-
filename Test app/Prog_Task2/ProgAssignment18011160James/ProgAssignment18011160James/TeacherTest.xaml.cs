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
    /// Interaction logic for TeacherTest.xaml
    /// </summary>
    public partial class TeacherTest : UserControl
    {
        LandingStrip landingStrip;
        List<TestInfo> test;
        public TeacherTest(LandingStrip landingStrip)
        {
            InitializeComponent();
            this.landingStrip = landingStrip;
            test = new List<TestInfo>();
            test = Methods.fillTest();
            //adding contents of list to datagrid
            DgTests.ItemsSource = null;
            DgTests.Items.Refresh();
            DgTests.ItemsSource = test;
            DgTests.Items.Refresh();
        }

    }
}
