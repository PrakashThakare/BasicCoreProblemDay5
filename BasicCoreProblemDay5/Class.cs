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
        public void WapTwoNumber(int iValue1,int iValue2)
        {
            Console.WriteLine("Before Swaping Number is:"+iValue1 +" "+iValue2);
            iValue1 = iValue1 - iValue2;
            iValue2 = iValue1 + iValue2;
            iValue1 = iValue1 - iValue2;
            Console.WriteLine("After Swaping Number is:" + iValue1 +" "+iValue2);



        }
    }
}
