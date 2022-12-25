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
            int[] a = new int[3];

            Console.WriteLine("Enter First Number ");
            int iValue1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number ");
            int iValue2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Three Number ");
            int iValue3 = Convert.ToInt32(Console.ReadLine());
            Class obj = new Class();   // create object
            obj.LargeNumber(iValue1,iValue2,iValue3);        //
            Console.ReadLine();
            
        }
    }
}
