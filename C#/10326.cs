using System;
class Program
{
    static void Main(string[] args)
    {
        string[] inputString = Console.ReadLine().Split(' ');
        int[] inputInt = new int[] { int.Parse(inputString[0]), int.Parse(inputString[2]) };
        int[] outputInt = new int[4];
        for (int i = 0; ; i++)
        {
            inputInt[i % 2]--;
            outputInt[i % 4]++;
            if (inputInt[i % 2] <= 0)
                break;
        }
        Console.WriteLine(outputInt[0] + " " + outputInt[1] + " " + outputInt[2] + " " + outputInt[3]);

    }
}