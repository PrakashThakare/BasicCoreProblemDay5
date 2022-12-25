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
            Console.WriteLine("Enter Divident Number ");
            int iValue1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  Diviser Number ");
            int iValue2 = Convert.ToInt32(Console.ReadLine());
            Class obj = new Class();   // create object
            obj.QuotientRemainder(iValue1,iValue2);        //
            Console.ReadLine();
            
        }
    }
}
