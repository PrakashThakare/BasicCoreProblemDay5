using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblemDay5
{
    class Class
    {
        public void LargeNumber(int iValue1, int iValue2, int iValue3)
        {
            if((iValue1>iValue2)&&(iValue1>iValue3))
            {
                Console.WriteLine("{0} Number is  Greater",iValue1);
            }
            else if((iValue2 > iValue1) && (iValue2 > iValue3))
            {
                Console.WriteLine("{0} Number is Greater", iValue2);
            }
            else
            {
                Console.WriteLine("{0} Number is Greater",iValue3);
            }
            

        }
    }
}
