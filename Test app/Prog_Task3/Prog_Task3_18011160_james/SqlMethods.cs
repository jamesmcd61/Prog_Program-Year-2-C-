using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace Prog_Task3_18011160_james
{
    public class SqlMethods
    {

        static string connetionString;
        public static string connection()
        {
            //connection for the DB
            SqlConnection cnn;
            //string path = System.IO.Directory.GetCurrentDirectory();
            //connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bezzi\Desktop\ProgTask1_18011160_JamesMcDonald\ProgAssignment18011160James\ProgAssignment18011160James\DatabaseINFO.mdf;Integrated Security=True";
            //connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+path+@"\DatabaseINFO.mdf;Integrated Security=True";
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            return connetionString;
        }
        //method to fill in the Db
        public static void SaveInfo(Info.TestInfo info)
        {
            //conenction
            using (SqlConnection cnn = new SqlConnection(connection()))
            {
                //insert to certain columns with the variable
                cnn.Open();
                cnn.Execute("insert into TestInfo (Question,AnswerA,AnswerB,AnswerC,AnswerD,ActualAnswer,Test) values (@Question,@AnswerA,@AnswerB,@AnswerC,@AnswerD,@ActualAnswer,@Test)", info);
            }
        } 
        //method to get all info for test
        public static List<Info.TestInfo> fillTest()
        {
            
            //connection
            using (IDbConnection cnn = new SqlConnection(connection()))
            {
                cnn.Open();
                //selects info
                var info = cnn.Query<Info.TestInfo>("select * from TestInfo");

                return info.ToList();
            }
        }
        
        //mehtod to make a user
        public static void addUser(Info.UserInfo Uinfo)
        {
            //connection
            using (IDbConnection cnn = new SqlConnection(connection()))
            {
                cnn.Open();
                //inserts into user table
                cnn.Execute("insert into Login (UserName,PassWord) values (@UserName,@PassWord)", Uinfo);
            }
        }
        //method fill the questions
        public static List<Info.TestInfo> fillQuestions()
        {
            //connetion
            using (IDbConnection cnn = new SqlConnection(connection()))
            {
                cnn.Open();
                //selects the record that meet requirement
                var info = cnn.Query<Info.TestInfo>("select * from TestInfo");

                return info.ToList();
            }
        }
       
        //methods to fill user info
        public static List<Info.UserInfo> fillUser()
        {
            //connection
            using (IDbConnection cnn = new SqlConnection(connection()))
            {
                cnn.Open();
                //gets all infor from login table
                var info = cnn.Query<Info.UserInfo>("select * from Login");

                return info.ToList();
            }
        }
        //inserts the mark info into the table
        public static void SaveMark(Info.MarkInfo info)
        {
            //connection
            using (IDbConnection cnn = new SqlConnection(connection()))
            {
                //inserts into table
                cnn.Execute("insert into Marks (Test,ActualAnswer,TheirAnswer,Question,StudentId) values (@Test,@ActualAnswer,@TheirAnswer,@Question,@StudentId)", info);
            }
        }
        //method to get the student info from that id
       /* public static List<Info.TestInfo> fillMarksForStudent(string personid)
        {
            //connection
            using (IDbConnection cnn = new SqlConnection(connection()))
            {
                var info = cnn.Query<Info.MarkInfo>("select * from Marks where StudentId ='" + personid + "'");

                return info.ToList();
            }
        }*/
        //method to get all mark info
        public static List<Info.MarkInfo> fillMarks()
        {
            //connection
            using (IDbConnection cnn = new SqlConnection(connection()))
            {
                cnn.Open();
                //gets mark info
                var info = cnn.Query<Info.MarkInfo>("select * from Markinfo");

                return info.ToList();
            }
        }
        //method to get the data for the student
        public static List<Info.UserInfo> fillStudents()
        {
            //connection
            using (IDbConnection cnn = new SqlConnection(connection()))
            {
                var info = cnn.Query<Info.UserInfo>("select * from Login  where UserName = 'Student'");

                return info.ToList();
            }
        }
        public static List<Info.StudentInfo> fillStudent()
        {
            //connection
            using (IDbConnection cnn = new SqlConnection(connection()))
            {
                var info = cnn.Query<Info.StudentInfo>("select Id, UserName from Login  where UserName = 'Student'");
                return info.ToList();
            }
        }

    
    }
}