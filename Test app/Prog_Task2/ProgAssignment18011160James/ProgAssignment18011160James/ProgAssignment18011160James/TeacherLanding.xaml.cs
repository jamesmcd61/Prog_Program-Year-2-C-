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
        LandingStrip landingStrip;
        public TeacherLanding(LandingStrip landingStrip)
        {
            InitializeComponent();
            this.landingStrip = landingStrip;
        }

        private void BtCreateTest_Click(object sender, RoutedEventArgs e)
        {
            landingStrip.displayCreateTest();
        }
    }
}
