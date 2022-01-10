using System;


class Program
{
    static void Main(string[] args)
    {
        string[] mainInput = Console.ReadLine().Split(' ');
        int n = int.Parse(mainInput[0]);
        string peaPos = mainInput[1];
        for (int i = 0; i < n; i++)
        {
            string[] replacedGlasses = Console.ReadLine().Split(' ');
            if (replacedGlasses[0] == peaPos)
            {
                peaPos = replacedGlasses[1];
            }
            else if (replacedGlasses[1] == peaPos)
            {
                peaPos = replacedGlasses[0];
            }
        }

        Console.WriteLine(peaPos);

    }
}
