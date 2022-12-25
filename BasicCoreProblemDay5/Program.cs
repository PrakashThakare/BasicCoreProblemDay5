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
            Console.WriteLine("Enter yaer ");
            int iCnt = Convert.ToInt32(Console.ReadLine());
            Class obj = new Class();   // create object
            obj.LeapYear(iCnt);        //
            Console.ReadLine();
            
        }
    }
}
