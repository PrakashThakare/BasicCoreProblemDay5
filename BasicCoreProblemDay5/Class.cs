using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblemDay5
{
    class Class
    {
        public void PowerOFTwo(int iCnt)
        {
            int iNumber = 1;
            if ((0 <= iCnt) && (iCnt < 31))
            {
                for (int i = 1; i <= iCnt; i++)
                {
                    iNumber *= 2;
                    Console.WriteLine(iNumber);
                }
            }
            else 
            {
                Console.WriteLine("Invalid Input");
            }


        }
    }
}
