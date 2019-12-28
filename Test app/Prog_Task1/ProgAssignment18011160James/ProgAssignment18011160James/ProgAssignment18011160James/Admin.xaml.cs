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
using System.Data;

namespace ProgAssignment18011160James
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : UserControl
    {
        List<UserInfo> user;

        public Admin()
        {
            InitializeComponent();
            user = new List<UserInfo>();
        }

        private void BTRefresh_Click(object sender, RoutedEventArgs e)
        {
            user = Methods.fillUser();

            DgUserDisplay.ItemsSource = user;

        
          
        }

        private void BtAddUser_Click(object sender, RoutedEventArgs e)
        {
            bool hasit = false;
            user = Methods.fillUser();
            UserInfo U = new UserInfo();

            U.PassWord = TBPassword.Text;

            foreach (UserInfo i in user)
            {
                if(U.PassWord == i.PassWord)
                {
                    hasit = true;
                }

            }
            if (hasit == false)
            {
                if (RbStudent.IsChecked == true)
                {
                    U.UserName = "Student";
                }
                else
                if (RBTeacher.IsChecked == true)
                {
                    U.UserName = "Teacher";
                }
                Methods.addUser(U);
                MessageBox.Show("Your UserName is: "+U.UserName
                    +"\nYour PassWord is: "+U.PassWord);
            }
            else
            {
                MessageBox.Show("That Password is not Available Please Choose another.");
            }

        }

        private void DgUserDisplay_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
