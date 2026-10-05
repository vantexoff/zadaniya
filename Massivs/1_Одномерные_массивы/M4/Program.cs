using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 25, 30, 5, 60, 15, 8 };
        int a = 12, b = 5;

        // M4.1
        int sum20 = 0, sumA = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] <= 20) sum20 += arr[i];
            if (arr[i] > a) sumA += arr[i];
        }
        Console.WriteLine($"M4.1а: сумма элементов, не превышающих 20 = {sum20}");
        Console.WriteLine($"M4.1б: сумма элементов, больших a({a}) = {sumA}");

        // M4.2
        int sumOdd = 0, sumMultA = 0, sumAB = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0) sumOdd += arr[i];
            if (arr[i] % a == 0) sumMultA += arr[i];
            if (arr[i] % a == 0 || arr[i] % b == 0) sumAB += arr[i];
        }
        Console.WriteLine($"M4.2а: сумма нечетных элементов = {sumOdd}");
        Console.WriteLine($"M4.2б: сумма элементов, кратных {a} = {sumMultA}");
        Console.WriteLine($"M4.2в: сумма элементов, кратных {a} или {b} = {sumAB}");

        // M4.3
        int sumMore20 = 0, sumLess50 = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 20) sumMore20 += arr[i];
            if (arr[i] < 50) sumLess50 += arr[i];
        }
        bool check1 = sumMore20 > 100;
        bool check2 = sumLess50 % 2 == 0;
        Console.WriteLine($"M4.3а: сумма элементов > 20 = {sumMore20}; превышает 100? {check1}");
        Console.WriteLine($"M4.3б: сумма элементов < 50 = {sumLess50}; четное число? {check2}");

        // M4.4
        int countNotLast = 0, countMultA = 0;
        int last = arr[arr.Length - 1];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != last) countNotLast++;
            if (arr[i] % a == 0) countMultA++;
        }
        Console.WriteLine($"M4.4а: количество элементов, отличных от последнего ({last}) = {countNotLast}");
        Console.WriteLine($"M4.4б: количество элементов, кратных {a} = {countMultA}");
    }
}
