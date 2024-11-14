using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegate
{
    public delegate void DisplayMsg();
    internal class Program
    {
        static void PassMsg()
        {
            Console.WriteLine("You are pass");
        }
        static void FailMsg()
        {
            Console.WriteLine("You are fail !");
        }
        static void Main(string[] args)
        {
            Student stud=new Student();
            stud.pass += new DisplayMsg(PassMsg);
            stud.fail += new DisplayMsg(FailMsg);

            stud.AcceptMarks(50);
        }
    }
}
