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
        public void QuotientRemainder(int iDevident,int iDivisor)
        {
            int iQuotient = iDevident / iDivisor;
            Console.WriteLine("Quotient is: "+iQuotient);
            int iRemainder = iDevident % iDivisor;
            Console.WriteLine("Remainder is: " + iRemainder);
        }
    }
}
