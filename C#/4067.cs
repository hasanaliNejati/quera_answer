using System;
class Program
{
    static void Main(string[] args)
    {
        int length = int.Parse(Console.ReadLine());

        int[] output = new int[length];
        for (int i = 0; i < length; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            if (x == y)
            {
                if (x % 2 > 0)
                {
                    output[i] = (x + y) - 1;
                }
                else
                {
                    output[i] = x + y;
                }
            }
            else if (y == x - 2 && x >= 2)
            {
                if (x % 2 > 0)
                {
                    output[i] = (x + y) - 1;
                }
                else
                {
                    output[i] = x + y;
                }
            }
            else
            {
                output[i] = -1;
            }
        }
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(output[i]);
        }
    }
}