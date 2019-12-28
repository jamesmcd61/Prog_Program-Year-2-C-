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
            //connection for the DB
            SqlConnection cnn;
            //string path = System.IO.Directory.GetCurrentDirectory();
            //connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bezzi\Desktop\ProgTask1_18011160_JamesMcDonald\ProgAssignment18011160James\ProgAssignment18011160James\DatabaseINFO.mdf;Integrated Security=True";
            //connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+path+@"\DatabaseINFO.mdf;Integrated Security=True";
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseINFO.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            return connetionString;
        }
        //method to fill in the Db
        public static void SaveInfo(TestInfo info)
        {
            //conenction
            using (SqlConnection cnn = new SqlConnection(connection()))
            {
                //insert to certain columns with the variable
                cnn.Execute("insert into Tests (Question,AnswerA,AnswerB,AnswerC,AnswerD,ActualAnswer,Test) values (@Question,@AnswerA,@AnswerB,@AnswerC,@AnswerD,@ActualAnswer,@Test)", info);
            }                     
        }
        //mehtod to make a user
        public static void addUser(UserInfo Uinfo)
        {
            //connection
            using (IDbConnection cnn = new SqlConnection(connection()))
            {
                //inserts into user table
                cnn.Execute("insert into Login (UserName,PassWord) values (@UserName,@PassWord)", Uinfo);
            }
        }
        //method fill the questions
        public static List<TestInfo> fillQuestions(string testSelected)
        {
            //connetion
            using (IDbConnection cnn = new SqlConnection(connection()))
            {
                //selects the record that meet requirement
                var info = cnn.Query<TestInfo>("select * from Tests where Test = '"+testSelected+"'");

                return info.ToList();
            }
        }
        //method to get all info for test
        public static List<TestInfo> fillTest()
        {
            //connection
            using (IDbConnection cnn = new SqlConnection(connection()))
            {
                //selects info
                var info = cnn.Query<TestInfo>("select * from Tests");

                return info.ToList();
            }
        }
        //methods to fill user info
        public static List<UserInfo> fillUser()
        {
            //connection
            using (IDbConnection cnn = new SqlConnection(connection()))
            {
                //gets all infor from login table
                var info = cnn.Query<UserInfo>("select * from Login");

                return info.ToList();
            }
        }
        //inserts the mark info into the table
        public static void SaveMark(MarkInfo info)
        {
            //connection
            using (IDbConnection cnn = new SqlConnection(connection()))
            {
                //inserts into table
                cnn.Execute("insert into Marks (Test,ActualAnswer,TheirAnswer,Question,StudentId) values (@Test,@ActualAnswer,@TheirAnswer,@Question,@StudentId)", info);
            }
        }
        //method to get the student info from that id
        public static List<MarkInfo> fillMarksForStudent(string personid)
        {
            //connection
            using (IDbConnection cnn = new SqlConnection(connection()))
            {
                var info = cnn.Query<MarkInfo>("select * from Marks where StudentId ='"+personid+"'");

                return info.ToList();
            }
        }
        //method to get all mark info
        public static List<MarkInfo> fillMarks()
        {
            //connection
            using (IDbConnection cnn = new SqlConnection(connection()))
            {
                //gets mark info
                var info = cnn.Query<MarkInfo>("select * from Marks");

                return info.ToList();
            }
        }
        //method to get the data for the student
        public static List<UserInfo> fillStudents()
        {
            //connection
            using (IDbConnection cnn = new SqlConnection(connection()))
            {
                var info = cnn.Query<UserInfo>("select * from Login  where UserName = 'Student'");

                return info.ToList();
            }
        }
        public static List<StudentInfo> fillStudent()
        {
            //connection
            using (IDbConnection cnn = new SqlConnection(connection()))
            {
                var info = cnn.Query<StudentInfo>("select Id, UserName from Login  where UserName = 'Student'");
                return info.ToList();
            }
        }


    }
}
/*
*/
