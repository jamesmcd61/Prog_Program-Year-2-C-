using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace ProgAssignment18011160James
{

    class Methods
    {
        static string connetionString;
        public static string connection()
        {
           
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Assessments\ProgAssignment18011160James\ProgAssignment18011160James\DatabaseINFO.mdf;Integrated Security=True";
            //connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\DatabaseINFO.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            return connetionString;
        }
        public static void SaveInfo(TestInfo info)
        {
            using (IDbConnection cnn = new SqlConnection(connection()))
            {

                cnn.Execute("insert into Tests (Question,AnswerA,AnswerB,AnswerC,AnswerD,ActualAnswer,Test) values (@Question,@AnswerA,@AnswerB,@AnswerC,@AnswerD,@ActualAnswer,@Test)", info);
            }
        }
        public static void addUser(UserInfo Uinfo)
        {
            using (IDbConnection cnn = new SqlConnection(connection()))
            {

                cnn.Execute("insert into Login (UserName,PassWord) values (@UserName,@PassWord)", Uinfo);
            }
        }

        public static List<TestInfo> fillQuestions()
        {
            using (IDbConnection cnn = new SqlConnection(connection()))
            {
                var info = cnn.Query<TestInfo>("select Question from Tests");

                return info.ToList();
            }
        }
        public static List<TestInfo> fillTest()
        {
            using (IDbConnection cnn = new SqlConnection(connection()))
            {
                var info = cnn.Query<TestInfo>("select * from Tests");

                return info.ToList();
            }
        }
        public static List<UserInfo> fillUser()
        {
            using (IDbConnection cnn = new SqlConnection(connection()))
            {
                var info = cnn.Query<UserInfo>("select * from Login");

                return info.ToList();
            }
        }
        public static void SaveMark(MarkInfo info)
        {
            using (IDbConnection cnn = new SqlConnection(connection()))
            {

                cnn.Execute("insert into Marks (Test,ActualAnswer,TheirAnswer,Question) values ()", info);
            }
        }


    }
}
/*

        public static List<MarkInfo> fillMarks()
        {
            using (IDbConnection cnn = new SqlConnection())
            {
                var info = cnn.Query<MarkInfo>("select * from Marks");

                return info.ToList();
            }
        }*/
