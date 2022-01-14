using System;
class Program
{
    static void Main(string[] args)
    {
        Console.ReadLine();
        string[] inputString = Console.ReadLine().Split(' ');

        long output = 0;
        for (int i = 0; i < inputString.Length; i++)
        {

            if (int.Parse(inputString[i]) < 0)
            {
                output += inputString.Length-1;
            }

        }
        Console.WriteLine(output);

    }
}