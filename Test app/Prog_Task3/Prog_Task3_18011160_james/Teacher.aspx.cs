using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Input;
namespace Prog_Task3_18011160_james
{
    public partial class Teacher : System.Web.UI.Page
    {

        string actualAnswer;
        List<Info.TestInfo> saved = new List<Info.TestInfo>();
        Boolean isthere = false;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("TeacherLanding.aspx");
        }

        protected void BtLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void BtCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TbQuestion.Text) || string.IsNullOrWhiteSpace(TbQuestion.Text) || string.IsNullOrEmpty(TbA.Text) || string.IsNullOrWhiteSpace(TbA.Text) || string.IsNullOrEmpty(TbB.Text) || string.IsNullOrWhiteSpace(TbB.Text) || string.IsNullOrEmpty(TbC.Text) || string.IsNullOrWhiteSpace(TbC.Text) || string.IsNullOrEmpty(TbD.Text) || string.IsNullOrWhiteSpace(TbD.Text) || string.IsNullOrEmpty(TbTestNO.Text) || string.IsNullOrWhiteSpace(TbTestNO.Text))
            {

            }
            else
            {
                //checking what they checked for the real answer
                if ((bool)CbA.Checked == true)
                {
                    actualAnswer = "A";
                }
                if ((bool)CbB.Checked == true)
                {
                    actualAnswer = "B";
                }

                if ((bool)CbC.Checked == true)
                {
                    actualAnswer = "C";
                }

                if ((bool)CbD.Checked == true)
                {
                    actualAnswer = "D";
                }
                //making connection to objects and assigning them


                Info.TestInfo x = new Info.TestInfo();
                x.Question = TbQuestion.Text.ToString();
                x.AnswerA = TbA.Text.ToString();
                x.AnswerB = TbB.Text.ToString();
                x.AnswerC = TbC.Text.ToString();
                x.AnswerD = TbD.Text.ToString();
                x.ActualAnswer = actualAnswer.ToString();
                x.Test = TbTestNO.Text.ToString();
                //filling list
                saved = SqlMethods.fillTest();
                //looping through list
                foreach (var d in saved)
                {
                    //checking if they have made that question before
                    if (d.Question == x.Question.ToString())
                    {
                        isthere = true;
                    }

                }
                if (isthere == true)
                {
                    //telling them they have made that question before
                    //DLL.existingQuestion();
                }
                else
                {
                    //saves info to DB
                    //saving the info into db
                    SqlMethods.SaveInfo(x);

                }
                //message to say what you entered

                //clears for the text boxes and buttons
                TbQuestion.Text = "";
                TbA.Text = "";
                TbB.Text = "";
                TbC.Text = "";
                TbD.Text = "";
                TbTestNO.Text = "";
                CbA.Checked = false;
                CbB.Checked = false;
                CbC.Checked = false;
                CbD.Checked = false;
            }
        }
    }
}