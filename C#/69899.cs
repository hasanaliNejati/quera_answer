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
            string[] input = Console.ReadLine().Split(' ');

            int userNum = int.Parse(input[0]);
            int wordNum = int.Parse(input[1]);

            int[] foot = new int[userNum * 2];

            for (int i = 0; i < foot.Length; i += 2)
            {
                foot[i] = (i / 2) + 1;
                foot[i + 1] = (i / 2) + 1;


            }


            int i_word = 0;
            for (int i = 0; ;)
            {


                if (foot[i] != 0)
                {
                    i_word++;
                    Console.Write(foot[i] + " ");
                }



                if (i_word >= wordNum)
                {
                    foot[i] = 0;
                    Console.Write('\n');
                    i_word = 0;
                    int winer = checkEnd(foot);
                    if (winer > 0)
                    {
                        Console.WriteLine("winner:" + winer);
                        break;
                    }
                }
                if (i < foot.Length - 1) i++; else i = 0;
            }

            



            Console.ReadKey();

        }

        private static int checkEnd(int[] input)
        {
            List<int> foot = new List<int>();
            foreach (int i in input)
            {
                if (i != 0) foot.Add(i);
            }
            if (foot.Count > 2)
                return 0;
            else if (foot.Count == 1)
                return foot[0];
            else if (foot[0] == foot[1])
                return foot[0];
            else
                return 0;
        }

    }
}
