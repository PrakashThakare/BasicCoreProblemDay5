using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblemDay5
{
    class Class
    {
        public void PrimeFactor(int iCnt)
        {
            int IFactor = 0;
            for (int i = 2; i<=iCnt; i++)
            {
                    while (iCnt % i == 0)
                {
                    Console.WriteLine(i);
                    iCnt = iCnt / i;
                }
                        
                    
            }
        }
    }
}
