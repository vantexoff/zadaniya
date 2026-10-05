using System;

class Program
{
    static void Main()
    {
        int[,] arr = {
            { 11, 12, 13, 14, 15, 16 },
            { 21, 22, 23, 24, 25, 26 },
            { 31, 32, 33, 34, 35, 36 },
            { 41, 42, 43, 44, 45, 46 },
            { 51, 52, 53, 54, 55, 56 }
        };
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);

        // D1.1
        // а)
        Console.WriteLine("D1.1а (правый верхний угол): " + arr[0, cols - 1]);
        // б)
        Console.WriteLine("D1.1б (левый нижний угол): " + arr[rows - 1, 0]);

        // D1.2
        // а)
        Console.WriteLine("D1.2а (правый нижний угол): " + arr[rows - 1, cols - 1]);
        // б)
        Console.WriteLine("D1.2б (левый верхний угол): " + arr[0, 0]);

        // D1.3
        // а)
        Console.WriteLine("D1.3а (элемент второй строки): " + arr[1, 0]);
        // б)
        Console.WriteLine("D1.3б (любой элемент массива): " + arr[2, 3]);

        // D1.4
        // а)
        Console.WriteLine("D1.4а (элемент третьего столбца): " + arr[0, 2]);
        // б)
        Console.WriteLine("D1.4б (любой элемент массива): " + arr[1, 1]);

        // D1.5
        // а)
        Console.Write("D1.5а (элементы пятой строки):");
        for (int j = 0; j < cols; j++) Console.Write(" " + arr[4, j]);
        Console.WriteLine();

        // б)
        Console.Write("Введите номер столбца s (от 1 до " + cols + "): ");
        int s = int.Parse(Console.ReadLine() ?? "1");
        int sIndex = s - 1;
        Console.Write("D1.5б (элементы " + s + "-го столбца):");
        for (int i = 0; i < rows; i++) Console.Write(" " + arr[i, sIndex]);
        Console.WriteLine();
    }
}
