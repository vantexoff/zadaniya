using System;

class Program
{
    static void PrintGrid(int[,] grid)
    {
        int r = grid.GetLength(0), c = grid.GetLength(1);
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
                Console.Write(grid[i, j].ToString().PadLeft(4));
            Console.WriteLine();
        }
    }

    static void Main()
    {
        // D2.1
        Console.WriteLine("D2.1 (таблица умножения 9x9):");
        int[,] mult = new int[9, 9];
        for (int i = 0; i < 9; i++)
            for (int j = 0; j < 9; j++)
                mult[i, j] = (i + 1) * (j + 1);
        PrintGrid(mult);

        // D2.2
        int[,] d22a = new int[7, 7];
        for (int i = 0; i < 7; i++) { d22a[i, i] = 1; d22a[i, 6 - i] = 1; }
        Console.WriteLine("D2.2а (крест по диагоналям 7x7):");
        PrintGrid(d22a);

        int[,] d22b = new int[7, 7];
        for (int i = 0; i < 7; i++)
            for (int j = 0; j < 7; j++)
                if (i == j || i == 6 - j || i == 3 || j == 3) d22b[i, j] = 1;
        Console.WriteLine("D2.2б (диагонали + средние строка/столбец 7x7):");
        PrintGrid(d22b);

        int[,] d22v = new int[7, 7];
        for (int i = 0; i < 7; i++)
            for (int j = i; j < 7 - i; j++) d22v[i, j] = 1;
        Console.WriteLine("D2.2в (треугольник/пирамида 7x7):");
        PrintGrid(d22v);

        // D2.3
        int[,] d23a = new int[6, 6];
        for (int j = 0; j < 6; j++) d23a[0, j] = 1;
        for (int i = 1; i < 6; i++)
        {
            d23a[i, 0] = 1;
            for (int j = 1; j < 6; j++) d23a[i, j] = d23a[i - 1, j] + d23a[i, j - 1];
        }
        Console.WriteLine("D2.3а (треугольник Паскаля в матрице 6x6):");
        PrintGrid(d23a);

        int[,] d23b = new int[6, 6];
        for (int i = 0; i < 6; i++)
            for (int j = 0; j < 6; j++)
                d23b[i, j] = (i + j) % 6 + 1;
        Console.WriteLine("D2.3б (диагональный числовой узор 6x6):");
        PrintGrid(d23b);

        // D2.4
        int[,] d24 = new int[5, 5];
        int valSnake = 1;
        for (int i = 0; i < 5; i++)
        {
            if (i % 2 == 0)
                for (int j = 0; j < 5; j++) d24[i, j] = valSnake++;
            else
                for (int j = 4; j >= 0; j--) d24[i, j] = valSnake++;
        }
        Console.WriteLine("D2.4 (заполнение \"змейкой\" 5x5 — см. примечание в коде про отсутствующие рисунки):");
        PrintGrid(d24);

        // D2.5

        // а)
        int nEven = 8;
        int[,] chessEven = new int[nEven, nEven];
        for (int i = 0; i < nEven; i++)
            for (int j = 0; j < nEven; j++)
                chessEven[i, j] = ((i + j) % 2 != 0) ? 1 : 0;
        Console.WriteLine("D2.5а (шахматная доска, n=" + nEven + ", чётное):");
        PrintGrid(chessEven);
        Console.WriteLine("Проверка: левое нижнее поле = " + chessEven[nEven - 1, 0] + " (должно быть 1)");

        // б)
        int nOdd = 7;
        int[,] chessOdd = new int[nOdd, nOdd];
        for (int i = 0; i < nOdd; i++)
            for (int j = 0; j < nOdd; j++)
                chessOdd[i, j] = ((i + j) % 2 == 0) ? 1 : 0;
        Console.WriteLine("D2.5б (шахматная доска, n=" + nOdd + ", нечётное):");
        PrintGrid(chessOdd);
        Console.WriteLine("Проверка: левое нижнее поле = " + chessOdd[nOdd - 1, 0] + " (должно быть 1)");

        // D2.6
        int[,] spiral = new int[5, 5];
        int val = 1, top = 0, bottom = 4, left = 0, right = 4;
        while (val <= 25)
        {
            for (int j = left; j <= right; j++) spiral[top, j] = val++;
            top++;
            for (int i = top; i <= bottom; i++) spiral[i, right] = val++;
            right--;
            for (int j = right; j >= left; j--) spiral[bottom, j] = val++;
            bottom--;
            for (int i = bottom; i >= top; i--) spiral[i, left] = val++;
            left++;
        }
        Console.WriteLine("D2.6 (спиральное заполнение 5x5):");
        PrintGrid(spiral);
    }
}
