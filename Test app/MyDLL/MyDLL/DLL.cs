using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;



namespace MyDLL
{
    public class DLL
    {
        public void passwordInUse()
        {
            //for admin control
            MessageBox.Show("That Password is not Available Please Choose another.");
        }
        public void mark()
        {
            //for mark on studentlanding
            MessageBox.Show("Your mark is 100%");
        }
        public void correctanswer()
        {
            //for test on student control
            MessageBox.Show("You are Correct,Please go to the next Quesiton");
        }
        public void Wronganswer()
        {
            //for test on student control
            MessageBox.Show("You where Wrong,Please go to the next Question");
        }
        public void alreadyanswered()
        {
            //for test on student control
            MessageBox.Show("You have Answered that question already for this Test");
        }
        public void existingQuestion()
        {
            //for teacher create test
            MessageBox.Show("You have made that question already for this Test");
        }
        
    }
}
