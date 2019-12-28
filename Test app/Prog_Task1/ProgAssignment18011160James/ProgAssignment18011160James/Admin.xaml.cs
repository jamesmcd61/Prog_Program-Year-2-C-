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
using MyDLL;

namespace ProgAssignment18011160James
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : UserControl
    {
        //creating a list to put data in that links to my objects
        List<UserInfo> user;
        
        public Admin()
        {
            InitializeComponent();
            user = new List<UserInfo>();
        }

        private void BTRefresh_Click(object sender, RoutedEventArgs e)
        {
            //filling the list
            user = Methods.fillUser();
            //adding what is in list directly to the datagrid
            DgUserDisplay.ItemsSource = user;

        
          
        }

        private void BtAddUser_Click(object sender, RoutedEventArgs e)
        {
            //making variables that i will need
            bool hasit = false;
            //adding data to list
            user = Methods.fillUser();
            UserInfo U = new UserInfo();
            
            U.PassWord = TBPassword.Text;
            //looping through the list
            foreach (UserInfo i in user)
            {
                //checking if the password that is entered is already assigned to another account
                if(U.PassWord == i.PassWord)
                {
                    hasit = true;
                }

            }
            //checking which type of person is getting an account
            if (hasit == false)
            {
                //checking if the Student is ticked to make sure to add it as there username
                if (RbStudent.IsChecked == true)
                {
                    U.UserName = "Student";
                }
                else
                //checking if the Teahcer is ticked to make sure to add it as there username
                if (RBTeacher.IsChecked == true)
                {
                    U.UserName = "Teacher";
                }
                //printing out what account they jsut made with there info
                Methods.addUser(U);
                MessageBox.Show("Your UserName is: "+U.UserName
                    +"\nYour PassWord is: "+U.PassWord);
            }
            else
            {
                //printing form dll that the password that they entered is allready in use for another account
                DLL.passwordInUse();
            }

        }

        private void DgUserDisplay_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
