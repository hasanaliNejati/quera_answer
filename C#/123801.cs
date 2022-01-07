using System;


class Program
{
    static void Main(string[] args)
    {
        string[] xPins = Console.ReadLine().Split(' ');
        string[] yPins = Console.ReadLine().Split(' ');

        for (int i = 0; i < 5; i++)
        {
            for (int i2 = 0; i2 < 5; i2++)
            {
                if (check(xPins, yPins))
                {
                    Console.WriteLine("Boro joloo :)");
                    return;
                }
                yPins = shift(yPins);
            }
            xPins = shift(xPins);
        }
        Console.WriteLine("Gir oftadi :(");
    }

    static string[] shift(string[] Pins)
    {
        string[] shifted = new string[Pins.Length];
        shifted[0] = Pins[Pins.Length - 1];
        for (int i = 1; i < Pins.Length; i++)
        {
            shifted[i] = Pins[i - 1];
        }
        return shifted;
    }

    static bool check(string[] xPins,string[] yPins)
    {
        int num1 = oneNumeSum(int.Parse(xPins[0]),int.Parse(yPins[0])) * 100;
        int num2 = oneNumeSum(int.Parse(xPins[1]),int.Parse(yPins[1])) *10;
        int num3 = oneNumeSum(int.Parse(xPins[2]),int.Parse(yPins[2]));
        int result = num1 + num2 + num3;
        return (result % 6) == 0;
    }

    static int oneNumeSum(int a, int b)
    {
        return (a + b) % 10;
    }
}