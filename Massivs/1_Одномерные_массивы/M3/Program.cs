using System;

class Program
{
    static void Main()
    {
        int[] arr = { 5, 120, -3, 40, 100, 250, 0, 18, 99 };

        // M3.1
        Console.Write("M3.1а (неотрицательные элементы): ");
        for (int i = 0; i < arr.Length; i++) if (arr[i] >= 0) Console.Write(arr[i] + " ");
        Console.WriteLine();

        Console.Write("M3.1б (не превышают 100): ");
        for (int i = 0; i < arr.Length; i++) if (arr[i] <= 100) Console.Write(arr[i] + " ");
        Console.WriteLine();

        // M3.2
        Console.Write("M3.2а (четные элементы): ");
        for (int i = 0; i < arr.Length; i++) if (arr[i] % 2 == 0) Console.Write(arr[i] + " ");
        Console.WriteLine();

        Console.Write("M3.2б (оканчиваются нулем): ");
        for (int i = 0; i < arr.Length; i++) if (arr[i] % 10 == 0) Console.Write(arr[i] + " ");
        Console.WriteLine();

        // M3.3
        int[] natArr = { 5, 47, 120, 8, 99, 340, 7, 250 };

        Console.Write("M3.3а (двузначные числа): ");
        for (int i = 0; i < natArr.Length; i++) if (natArr[i] >= 10 && natArr[i] <= 99) Console.Write(natArr[i] + " ");
        Console.WriteLine();

        Console.Write("M3.3б (трехзначные числа): ");
        for (int i = 0; i < natArr.Length; i++) if (natArr[i] >= 100 && natArr[i] <= 999) Console.Write(natArr[i] + " ");
        Console.WriteLine();

        // M3.4
        Console.Write("M3.4а (2-й, 4-й, ... элементы): ");
        for (int i = 1; i < arr.Length; i += 2) Console.Write(arr[i] + " ");
        Console.WriteLine();

        Console.Write("M3.4б (3-й, 6-й, ... элементы): ");
        for (int i = 2; i < arr.Length; i += 3) Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}
