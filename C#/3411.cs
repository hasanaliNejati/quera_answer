
//حل با روش من در آوردی
// :)
using System;
class Program
{
    static void Main(string[] args)
    {
        long input = (long.Parse(Console.ReadLine()));
        for (long i = input-1; i > 1 ; i--)
        {
            input = getSmallest2(input)*getSmallest2(i);
        }
        Console.WriteLine(getSmallest(input));
    }

    static long getSmallest(long input)
    {
        for (; (input % 10) == 0; input /= 10)
            continue;
        return input%10;
    }

    static long getSmallest2(long input)
    {
        for (; (input % 10) == 0; input /= 10)
            continue;
        return input % 1000000;
    }

}