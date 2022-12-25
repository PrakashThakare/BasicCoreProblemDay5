using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblemDay5
{
    class Class
    {
        public void LeapYear(int iCnt)
        {
            if (((iCnt % 4 == 0) && (iCnt % 100 != 0)) || (iCnt % 400 == 0))
            {
                Console.WriteLine("It is a leap Year ");
            }
            else
            {
                Console.WriteLine("It is a Not leap Year ");
            }
        }
    }
}
