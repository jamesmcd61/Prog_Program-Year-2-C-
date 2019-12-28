using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prog_Task3_18011160_james
{
    public class Info
    {
       public  class TestInfo
        {
            public int id { get; set; }
            public string Question { get; set; }
            public string AnswerA { get; set; }
            public string AnswerB { get; set; }
            public string AnswerC { get; set; }
            public string AnswerD { get; set; }
            public string ActualAnswer { get; set; }
            public string Test { get; set; }

        }
        public class MarkInfo
        {
            public int id { get; set; }
            public string Test { get; set; }
            public string ActualAnswer { get; set; }
            public string TheirAnswer { get; set; }
            public string Question { get; set; }
            public string StudentId { get; set; }
        }

        public class UserInfo
        {
            public int id { get; set; }
            public string UserName { get; set; }
            public string PassWord { get; set; }
        }
        public class StudentInfo
        {
            public int id { get; set; }
            public string UserName { get; set; }

        }
    }
}