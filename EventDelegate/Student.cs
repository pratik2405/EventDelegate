using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegate
{
    public class Student
    {
        public event DisplayMsg pass;
        public event DisplayMsg fail;

        public void AcceptMarks(int mark)
        {
            if (mark >= 40)
            {
                pass();
            }
            else
            {
                fail();
            }
        }
    }
}
