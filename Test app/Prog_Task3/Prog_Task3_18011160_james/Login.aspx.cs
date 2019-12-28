using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Prog_Task3_18011160_james
{
    public partial class Login : System.Web.UI.Page
    {
        Teacher begin = new Teacher();
        List<Info.UserInfo> user = new List<Info.UserInfo>();
        //string role;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void BtLogin_Click(object sender, EventArgs e)
        {
            user = SqlMethods.fillUser();
            if (string.IsNullOrEmpty(TbUserName.Text) || string.IsNullOrWhiteSpace(TbUserName.Text) || string.IsNullOrEmpty(TbPassWord.Text) || string.IsNullOrWhiteSpace(TbPassWord.Text))
            {

            }
            else
            {
                foreach (Info.UserInfo u in user)
                {
                    //checking username and password
                    if (TbUserName.Text == u.UserName && TbPassWord.Text == u.PassWord)
                    {
                        switch (TbUserName.Text)
                        {
                            case "Admin":
                                //changing the panel to the user that login
                                Response.Redirect("Admin.aspx");
                                break;
                            case "Teacher":
                                //changing the panel to the user that login

                                Response.Redirect("TeacherLanding.aspx");
                                break;
                            case "Student":
                                //changing the panel to the user that login
                                Response.Redirect("StudentLanding.aspx");
                                Session["id"] = u.id;
                                break;
                        }
                    }


            
                }
            }
        }

    }
}