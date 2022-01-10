using System;


class Program
{
    static void Main(string[] args)
    {
        string day = Console.ReadLine();
        switch (day)
        {
            case "shanbe":
                Console.WriteLine("perspolis");
                break;
            case "yekshanbe":
                Console.WriteLine("bahman");
                break;
            case "doshanbe":
                Console.WriteLine("perspolis");
                break;
            case "seshanbe":
                Console.WriteLine("bahman");
                break;
            case "chaharshanbe":
                Console.WriteLine("perspolis");
                break;
            case "panjshanbe":
                Console.WriteLine("bahman");
                break;
            default:
                Console.WriteLine("tatil");
                break;

        }
        
    }
}