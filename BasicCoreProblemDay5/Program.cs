using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblemDay5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Alphabet");
            char cValue1 = Convert.ToChar(Console.ReadLine());
            Class obj = new Class();   // create object
            obj.Alphabet(cValue1);        //
            Console.ReadLine();
            
        }
    }
}
