using System;
class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        for (int i = 0; i < int.Parse(input[0]); i++)
        {
            Console.Write("copy of ");
        }
        Console.WriteLine(input[1]);
    }

}