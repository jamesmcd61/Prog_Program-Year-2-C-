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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LandingStrip beggining;
        List<UserInfo> user = new List<UserInfo>();
        public MainWindow()
        {
            InitializeComponent();
            beggining = new LandingStrip();

        }

        private void BTLogin_Click(object sender, RoutedEventArgs e)
        {
            user = Methods.fillUser();
            foreach(UserInfo u in user)
            {
                if(TBUserName.Text == u.UserName) {
                    beggining.displayUserView(TBUserName.Text);
                    this.Hide();
                }
            }
        }

    }
 }

