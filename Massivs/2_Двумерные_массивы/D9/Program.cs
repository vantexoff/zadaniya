using System;

class Program
{
    static void Print(string label, int[,] a)
    {
        Console.WriteLine(label);
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(a[i, j].ToString().PadLeft(5));
            Console.WriteLine();
        }
    }

    static void Print1D(string label, int[] a)
    {
        Console.WriteLine(label + string.Join(" ", a));
    }

    static void Main()
    {
        int[,] a = { { 10, -50 }, { 60, 20 } };
        int[,] b = { { 5, 10 }, { 70, -30 } };
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);
        Print("Массив A:", a);
        Print("Массив B:", b);

        // D9.1 а) и б)
        int[,] c1 = new int[rows, cols];
        int[,] c2 = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                c1[i, j] = a[i, j] + b[i, j];

                if ((a[i, j] >= 0 && b[i, j] >= 0) || (a[i, j] < 0 && b[i, j] < 0))
                    c2[i, j] = 100;
                else
                    c2[i, j] = 0;
            }
        }
        Print("D9.1 а) A+B:", c1);
        Print("D9.1 б) 100/0 при совпадении знаков:", c2);

        // D9.2 а) и б)
        int[,] c3 = new int[rows, cols];
        int[,] c4 = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                c3[i, j] = a[i, j] - b[i, j];
                c4[i, j] = (a[i, j] > 50 && b[i, j] > 50) ? 13 : 12;
            }
        }
        Print("D9.2 а) A-B:", c3);
        Print("D9.2 б) 13/12 при условии >50:", c4);

        // D9.3
        int[,] rain2009 = new int[12, 28];
        int[,] rain2010 = new int[12, 28];
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 28; j++)
            {
                rain2009[i, j] = (i + j) % 15;       // за 2009 год
                rain2010[i, j] = (i * 2 + j) % 20;   // за 2010 год
            }
        }

        int[,] rainDiff = new int[12, 28];
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 28; j++)
            {
                rainDiff[i, j] = rain2010[i, j] - rain2009[i, j];
            }
        }
        Print("D9.3 массив изменения количества осадков (2010-2009), мм:", rainDiff);

        // D9.4
        int m = rows, n_cols = cols;
        int[] flatRow = new int[m * n_cols];
        int[] flatCol = new int[m * n_cols];

        // а)
        int k1 = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n_cols; j++)
            {
                flatRow[k1++] = a[i, j];
            }
        }

        // б)
        int k2 = 0;
        for (int j = 0; j < n_cols; j++)
        {
            for (int i = 0; i < m; i++)
            {
                flatCol[k2++] = a[i, j];
            }
        }

        Print1D("D9.4 а) копирование по строкам: ", flatRow);
        Print1D("D9.4 б) копирование по столбцам: ", flatCol);

        // D9.5
        int n = 4;
        int[,] sq = new int[n, n];
        int val = 1;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                sq[i, j] = val++;

        Print("D9.5 исходный квадратный массив:", sq);

        int count = n * (n - 1) / 2;

        int[] aboveMain = new int[count];
        int[] belowMain = new int[count];
        int[] aboveSide = new int[count];
        int[] belowSide = new int[count];

        int idxAM = 0, idxBM = 0, idxAS = 0, idxBS = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                // а)
                if (j > i) aboveMain[idxAM++] = sq[i, j];

                // б)
                if (i > j) belowMain[idxBM++] = sq[i, j];

                // в)
                if (i + j < n - 1) aboveSide[idxAS++] = sq[i, j];

                // г)
                if (i + j > n - 1) belowSide[idxBS++] = sq[i, j];
            }
        }

        Print1D("D9.5 а) над главной диагональю: ", aboveMain);
        Print1D("D9.5 б) под главной диагональю: ", belowMain);
        Print1D("D9.5 в) над побочной диагональю: ", aboveSide);
        Print1D("D9.5 г) под побочной диагональю: ", belowSide);
    }
}
