using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prog_Task3_18011160_james
{
    public partial class Admin : System.Web.UI.Page
    {
        List<Info.UserInfo> user = new List<Info.UserInfo>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TbCreate_Click(object sender, EventArgs e)
        {
            //making variables that i will need
            bool hasit = false;
            //adding data to list
            user = SqlMethods.fillUser();
            Info.UserInfo U = new Info.UserInfo();

            U.PassWord = TbPassword.Text;
            //looping through the list
            foreach (Info.UserInfo i in user)
            {
                //checking if the password that is entered is already assigned to another account
                if (U.PassWord == i.PassWord)
                {
                    hasit = true;
                }

            }
            //checking which type of person is getting an account
            if (hasit == false)
            {
                //checking if the Student is ticked to make sure to add it as there username
                if (RbStudent.Checked == true)
                {
                    U.UserName = "Student";
                }
                else
                //checking if the Teahcer is ticked to make sure to add it as there username
                if (RbTeacher.Checked == true)
                {
                    U.UserName = "Teacher";
                }
                //printing out what account they jsut made with there info
                SqlMethods.addUser(U);
               
            }
            else
            {
                //printing form dll that the password that they entered is allready in use for another account
                
            }
        }
        public void addusers()
        {
            
        }
    }
}