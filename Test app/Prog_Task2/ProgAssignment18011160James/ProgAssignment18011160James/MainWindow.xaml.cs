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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //making a list and a connection to another conrol
        LandingStrip beggining;
        List<UserInfo> user = new List<UserInfo>();
        public static string PersonID { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            beggining = new LandingStrip();
            LbErrorPass.Visibility = Visibility.Hidden;
            LbErrorUser.Visibility = Visibility.Hidden;
        }

        private void BTLogin_Click(object sender, RoutedEventArgs e)
        {
            //filling list
            user = Methods.fillUser();
            //checking if they entered something
            if (TBUserName.Text.Length == 0 || TBUserName.Text == "UserName")
            {
                //printing from dll that there no username entered
                LbErrorUser.Visibility = Visibility.Visible;
            }               
            else
            {
                //checking if they entered something
                if (TBPassWord.Text.Length == 0 || TBPassWord.Text == "PassWord")
                {
                    //printing from dll that there no Password entered
                    LbErrorPass.Visibility = Visibility.Visible;
                 }
                 else
                 { //looping throuch the list that contakes info form login table and checking if valid user
                     foreach (UserInfo u in user)
                      {
                        //checking username and password
                         if (TBUserName.Text == u.UserName && TBPassWord.Text == u.PassWord)
                         {
                                //change to diffrent screen if right.
                                    beggining.displayUserView(TBUserName.Text);
                                    PersonID = u.id;
                                    this.Hide();                       
                        }

                      }
                  }

              }
          }

        private void TBUserName_GotFocus(object sender, RoutedEventArgs e)
        {
            TBUserName.Clear();
        }

        private void TBPassWord_GotFocus(object sender, RoutedEventArgs e)
        {
            TBPassWord.Clear();
        }
    }
}

 

