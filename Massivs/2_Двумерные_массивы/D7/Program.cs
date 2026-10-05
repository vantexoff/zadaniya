using System;

class Program
{
    static void Main()
    {
        int n = 4;
        int[,] a = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };

        // D7.1
        int r = 2;
        Console.WriteLine("D7.1: " + a[r, r]);

        // D7.2
        int c = 1;
        Console.WriteLine("D7.2: " + a[n - 1 - c, c]);

        // D7.3
        // а)
        Console.Write("D7.3 а) ");
        for (int i = 0; i < n; i++)
            Console.Write(a[i, i] + " ");
        Console.WriteLine();

        // б)
        Console.Write("D7.3 б) ");
        for (int i = n - 1; i >= 0; i--)
            Console.Write(a[i, n - 1 - i] + " ");
        Console.WriteLine();

        // D7.4
        // а)
        Console.Write("D7.4 а) ");
        for (int i = 0; i < n; i++)
            Console.Write(a[i, n - 1 - i] + " ");
        Console.WriteLine();

        // б)
        Console.Write("D7.4 б) ");
        for (int i = n - 1; i >= 0; i--)
            Console.Write(a[i, i] + " ");
        Console.WriteLine();

        // D7.5
   
        int sumMain = 0;
        int sumSide = 0;

        for (int i = 0; i < n; i++)
        {
            //а
            sumMain += a[i, i];
            //б
            sumSide += a[i, n - 1 - i];
        }

        Console.WriteLine("D7.5 а) сумма главной диагонали: " + sumMain);
        Console.WriteLine("D7.5 б) сумма побочной диагонали: " + sumSide);

        // D7.6
        // а)
        double avgMain = (double)sumMain / n;
        // б)
        double avgSide = (double)sumSide / n;

        Console.WriteLine("D7.6 а) среднее арифметическое главной диагонали: " + avgMain);
        Console.WriteLine("D7.6 б) среднее арифметическое побочной диагонали: " + avgSide);
    }
}
