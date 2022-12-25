using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblemDay5
{
    class Class
    {
        public void HarmonicNo(int iCnt)
        {
          
            double dValue = 0.0;
            Console.WriteLine("Harmonic series is: ");
            for (double i = 1; i <= iCnt; i++)
            {
                dValue = dValue + 1 / i;
                Console.WriteLine(dValue);
            }
        }
    }
}
