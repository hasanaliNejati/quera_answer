using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(factorial(int.Parse(Console.ReadLine())));
    }

    static int factorial(int num)
    {
        return (num == 1) ? 1 : num + factorial(num - 1);
    }
}