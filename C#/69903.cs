using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       

        static void Main(string[] args)
        {
            string[] date1 = Console.ReadLine().Split(' ');
            string[] date2 = Console.ReadLine().Split(' ');


            int mon1 = int.Parse(date1[0]);
            int day1 = int.Parse(date1[1]);

            int mon2 = int.Parse(date2[0]);
            int day2 = int.Parse(date2[1]);

            int dayOffset;
            if (int.Parse(date1[0]) <= int.Parse(date2[0]))
            {
                 dayOffset = (mon2 - mon1) * 30;
                dayOffset += mon1 < 7 ? (mon2 >= 7 ? 7 - mon1 : mon2 - mon1) : 0;
                dayOffset += day2 - day1;
            }
            else
            {
                 dayOffset = (mon1 - mon2) * 30;
                dayOffset += mon2 < 7 ? (mon1 >= 7 ? 7 - mon2 : mon1 - mon2) : 0;
                dayOffset += day1 - day2;
            }
            
            Console.Write( dayOffset <0?-dayOffset:dayOffset );
            Console.ReadKey();

        }

        
    }
}