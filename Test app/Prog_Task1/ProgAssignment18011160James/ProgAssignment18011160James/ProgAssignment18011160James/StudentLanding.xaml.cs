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
    /// Interaction logic for StudentLanding.xaml
    /// </summary>
    public partial class StudentLanding : UserControl
    {
        //Student tests = new Student();
        LandingStrip landingStrip;
        List<TestInfo> tests = new List<TestInfo>();
        public StudentLanding(LandingStrip landingStrip)
        {
            InitializeComponent();
            this.landingStrip = landingStrip;
            addAvaiableTests();
        }

        private void BTStartTest_Click(object sender, RoutedEventArgs e)
        {
            landingStrip.displaytest();
        }

        private void CBTests_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public void addAvaiableTests()
        {
            tests = Methods.fillTest();

            foreach(TestInfo t in tests)
            {
                if (t.Test != CBTests.Items.ToString())
                {
                    CBTests.Items.Add(t.Test);
                }
            }

        }
    }
}
