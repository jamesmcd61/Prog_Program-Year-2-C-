using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Prog_Task3_18011160_james
{
    public partial class TeacherLanding : System.Web.UI.Page
    {
        List<Info.MarkInfo> marks = new List<Info.MarkInfo>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtCreateTest_Click(object sender, EventArgs e)
        {
            Response.Redirect("Teacher.aspx");
        }

        protected void BtLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void GvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BtStudentmakrs_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(SqlMethods.connection()))
            {

                //gets mark info
                SqlDataAdapter sde = new SqlDataAdapter("select * from Markinfo", con);
                DataTable ds = new DataTable();
                sde.Fill(ds);
                GwDisplayMarks.DataSource = ds;
                GwDisplayMarks.DataBind();
            }

        }
    }
}