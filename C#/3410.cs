using System;
class Program
{
    static void Main(string[] args)
    {
        long hight = int.Parse(Console.ReadLine());
        drowKhaiam(new long[] { 1 }, hight);
    }

    static void drowKhaiam(long[] row, long hight)
    {
        write(row);

        long[] nextRow = new long[row.Length+1];
        nextRow[0] = 1;
        for (int i = 1;i < nextRow.Length-1;i++)
        {
            nextRow[i] = row[i-1]+row[i];
        }
        nextRow[nextRow.Length-1] = 1;

        if (row.Length >= hight)
            return;

        drowKhaiam(nextRow, hight);


    }

    static void write(long[] row)
    {
        for (int i = 0; i < row.Length; i++)
            Console.Write(row[i] + " ");
        Console.WriteLine();

    }

}