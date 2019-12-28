using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prog_Task3_18011160_james
{
    public partial class Student : System.Web.UI.Page
    {
        List<Info.TestInfo> test = new List<Info.TestInfo>();
        List<Info.MarkInfo> marks = new List<Info.MarkInfo>();
        char answer;
        string Test;
        string ActualAnswer;
        string TheirAnswer;
        string id;
        string q;
        bool isthere = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            filllist();
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentLanding.aspx");
        }

        protected void BtLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        public void filllist()
        {
            test = SqlMethods.fillQuestions();
            LBQuestions.Items.Clear();

            //looping through list
            foreach (Info.TestInfo n in test)
            {
                //adding to list box
                LBQuestions.Items.Add(new ListItem("Questions" + n.id));
            }
        }

        protected void LBQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                //assigning variable
                string questionslected = LBQuestions.SelectedItem.ToString();
                //filling list
                test = SqlMethods.fillTest();
                //looping through test
                foreach (Info.TestInfo t in test)
                {
                    //assigning variable
                   
                    //checking if the questions are correct and then adding the corrisponding info to that question to buttons
                    if (questionslected.Equals("Questions" + t.id))
                    {
                        //adding info to radio buttons
                        LblQuestion.Text = t.Question;
                        RbA.Text = t.AnswerA;
                        RbB.Text = t.AnswerA;
                        RbC.Text = t.AnswerC;
                        RbD.Text = t.AnswerD;
                    }
                }
            
        }

        protected void LBQuestions_Load(object sender, EventArgs e)
        {

        }

        protected void BtSubmit_Click(object sender, EventArgs e)
        {
            //filling list
            test = SqlMethods.fillTest();
            //assigning variable
            string questionselected = LBQuestions.SelectedItem.ToString();
            //checking what they answered
            if ((bool)RbA.Checked == true)
            {
                answer = 'A';
            }
            if ((bool)RbB.Checked == true)
            {
                answer = 'B';
            }
            if ((bool)RbC.Checked == true)
            {
                answer = 'C';
            }
            if ((bool)RbD.Checked == true)
            {
                answer = 'D';
            }
            //looping through list
            foreach (Info.TestInfo b in test)
            {
                //checking if the questions are the same
                if (questionselected == ("Questions" + b.id.ToString()))
                {
                    //chekcing is the answer they answered was right or wrong             
                    if (answer == b.ActualAnswer.ToCharArray()[0])
                    {
                        //adding data to variables
                        Test = b.Test.ToString();
                        ActualAnswer = b.ActualAnswer.ToString();
                        TheirAnswer = answer.ToString();
                        id = b.id.ToString();
                        //printing that they where right if that questioin had not been doen before
                        if (isthere == true)
                        {
                           //message
                        }
                    }
                    else
                    {
                        //adding data to variables
                        Test = b.Test.ToString();
                        ActualAnswer = b.ActualAnswer.ToString();
                        TheirAnswer = answer.ToString();
                        id = b.id.ToString();
                        //printing that they where wrong if that questioin had not been doen before
                        if (isthere == true)
                        {
                            //message
                        }
                    }

                }
            }
            //adding answers and other info to objects
            Info.MarkInfo m = new Info.MarkInfo();
            m.Test = Test;
            m.ActualAnswer = ActualAnswer;
            m.TheirAnswer = TheirAnswer;
            m.Question = "Question" + id;
           
            //filling list
            marks = SqlMethods.fillMarks();
            //looping through list
            foreach (Info.MarkInfo h in marks)
            {
                //checking is the person has answered this question before
                if (h.StudentId == Session["id"])
                { //checking iff match
                    if (h.Question == "Question" + id)
                    {
                        isthere = true;
                    }
                }

            }
            if (isthere == true)
            {
                //saying that they have answered that question before
                LBQuestions.Items.Remove(LBQuestions.SelectedItem);
                LBQuestions.SelectedIndex = LBQuestions.SelectedIndex + 1;
                //print out
                
                isthere = false;
            }
            else
            {
                //saves info to DB
                SqlMethods.SaveMark(m);

            }
        }
    }
}