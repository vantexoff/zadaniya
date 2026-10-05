using System;

class Program
{
    static int[,] Base()
    {
        return new int[,] {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 },
            { 16, 17, 18, 19, 20 },
            { 21, 22, 23, 24, 25 }
        };
    }

    static void Print(string label, int[,] a)
    {
        Console.WriteLine(label);
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(a[i, j].ToString().PadLeft(4));
            Console.WriteLine();
        }
    }

    static void Main()
    {
        // D8.1
        // а) и б)
        int[,] a1 = Base();
        int rows = a1.GetLength(0);
        int cols = a1.GetLength(1);
        Print("D8.1 исходный массив:", a1);

        int temp = a1[0, 0];
        a1[0, 0] = a1[rows - 1, 0];
        a1[rows - 1, 0] = temp;

        temp = a1[rows - 1, cols - 1];
        a1[rows - 1, cols - 1] = a1[0, cols - 1];
        a1[0, cols - 1] = temp;

        Print("D8.1 а,б) после обмена угловых элементов:", a1);

        // D8.2
        int[,] a2 = Base();
        Print("D8.2 исходный массив:", a2);

        int maxR = 0, maxC = 0, minR = 0, minC = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (a2[i, j] > a2[maxR, maxC]) { maxR = i; maxC = j; }  
                if (a2[i, j] <= a2[minR, minC]) { minR = i; minC = j; }  
            }
        }
        temp = a2[maxR, maxC];
        a2[maxR, maxC] = a2[minR, minC];
        a2[minR, minC] = temp;

        Console.WriteLine($"D8.2: первый максимум был в ({maxR + 1},{maxC + 1}), последний минимум был в ({minR + 1},{minC + 1})");
        Print("D8.2 после обмена:", a2);


        // D8.3
        int[,] a3 = Base();
        Print("D8.3 исходный массив:", a3);

        // а)
        for (int j = 0; j < cols; j++) a3[1, j] = 5;
        Print("D8.3 а) после замены 2-й строки числом 5:", a3);

        // б)
        for (int i = 0; i < rows; i++) a3[i, 4] = 10;
        Print("D8.3 б) после замены 5-го столбца числом 10:", a3);

        // D8.4
        int[,] a4 = Base();
        Print("D8.4 исходный массив:", a4);

        // а)
        for (int i = 0; i < rows; i++) a4[i, 2] = -12;
        Print("D8.4 а) после замены 3-го столбца числом -12:", a4);

        // б)
        for (int j = 0; j < cols; j++) a4[3, j] = 4;
        Print("D8.4 б) после замены 4-й строки числом 4:", a4);

        // D8.5
        int[,] a5 = Base();
        Print("D8.5 исходный массив:", a5);

        // а)
        int rowNum5 = 3;
        int num5a = 99;
        for (int j = 0; j < cols; j++) a5[rowNum5 - 1, j] = num5a;
        Print($"D8.5 а) после замены строки №{rowNum5} числом {num5a}:", a5);

        // б)
        int colNum5 = 2;
        int num5b = 77;
        for (int i = 0; i < rows; i++) a5[i, colNum5 - 1] = num5b;
        Print($"D8.5 б) после замены столбца №{colNum5} числом {num5b}:", a5);

        // D8.6
        int[,] a6 = Base();
        Print("D8.6 исходный массив:", a6);

        // а)
        int rowNum6 = 2;
        Console.WriteLine($"D8.6 а) Введите {cols} чисел для строки №{rowNum6}:");
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"  элемент [{rowNum6},{j + 1}]: ");
            a6[rowNum6 - 1, j] = int.Parse(Console.ReadLine() ?? "0");
        }
        Print($"D8.6 а) после замены строки №{rowNum6} введёнными числами:", a6);

        // б)
        int colNum6 = 3;
        Console.WriteLine($"D8.6 б) Введите {rows} чисел для столбца №{colNum6}:");
        for (int i = 0; i < rows; i++)
        {
            Console.Write($"  элемент [{i + 1},{colNum6}]: ");
            a6[i, colNum6 - 1] = int.Parse(Console.ReadLine() ?? "0");
        }
        Print($"D8.6 б) после замены столбца №{colNum6} введёнными числами:", a6);
    }
}
