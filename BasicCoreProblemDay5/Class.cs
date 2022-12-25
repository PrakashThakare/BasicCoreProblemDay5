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
        public void Alphabet(int iValue1)
        {
            if ((iValue1== 'a')||(iValue1=='e')||(iValue1 == 'i') || (iValue1 == 'o') || (iValue1 == 'u')|| (iValue1 == 'A') || (iValue1 == 'E') || (iValue1 == 'I') || (iValue1 == 'O') || (iValue1 == 'U') )
            {
                Console.WriteLine("It is Vowel");
            }
            else
            {
                Console.WriteLine("Number is Consonant");
            }
            

        }
    }
}
