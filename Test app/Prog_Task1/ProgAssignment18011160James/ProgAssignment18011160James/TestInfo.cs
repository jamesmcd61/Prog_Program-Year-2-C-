using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgAssignment18011160James
{
        class TestInfo
        {
            public string id { get; set; }
            public string Question { get; set; }
            public string AnswerA { get; set; }
            public string AnswerB { get; set; }
            public string AnswerC { get; set; }
            public string AnswerD { get; set; }
            public string ActualAnswer { get; set; }
            public string Test { get; set; }

        }
        class MarkInfo
        {
        public string id { get; set; }
        public string Test { get; set; }
        public string ActualAnswer { get; set; }
        public string TheirAnswer { get; set; }
        public string Question { get; set; }
        public string StudentId { get; set; }
    }

        class UserInfo
    {
        public string id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }

}
