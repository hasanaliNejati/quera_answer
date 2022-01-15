using System;
class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int time = int.Parse(input[0]);
        int a = int.Parse(input[1]);
        int b = int.Parse(input[2]);

        int ar_ar = 0;
        int ma_ma = 0;

        while(time > 0)
        {
            //ar_ar
            if (time > 0)
            {
                time--;
                ar_ar++;
                time -= a;
            }
            //ma_ma
            if (time > 0)
            {
                time--;
                ma_ma++;
                time -= b;
            }
        }

        Console.WriteLine(ar_ar + " " + ma_ma);
    }
}