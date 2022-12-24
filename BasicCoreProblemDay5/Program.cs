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
            int iTail = 0;
            int iHead = 0;
            Random random = new Random();
            Console.WriteLine("Enter number how many time flip the Coin");
            int iNumber = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=iNumber;i++)
            {
                Double check = random.NextDouble();
                if(check < 0.5)
                {
                    iTail++;
                }
                else
                {
                    iHead++;
                }
               
            }
            double percentage = (iTail * 100)/ iNumber;
            Console.WriteLine(" Tail is{0} and its percentage is : {1} ",iTail,percentage);
            double percentage1 = (iHead * 100)/ iNumber;
            Console.WriteLine("Head is{0} and its percentage is  :{1} " ,iHead,percentage1);
            Console.ReadLine();
            
        }
    }
}
