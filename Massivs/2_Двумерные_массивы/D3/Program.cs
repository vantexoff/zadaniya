using System;

class Program
{
    static void Main()
    {
        int[,] a = {
            { 11, 12, 13, 14, 15 },
            { 21, 22, 23, 24, 25 },
            { 31, 32, 33, 34, 35 },
            { 41, 42, 43, 44, 45 },
            { 51, 52, 53, 54, 55 }
        };
        int rows = a.GetLength(0), cols = a.GetLength(1);

        // D3.1
        // а)
        int sumRow3 = 0;
        for (int j = 0; j < cols; j++) sumRow3 += a[2, j];
        Console.WriteLine("D3.1а (сумма 3-й строки): " + sumRow3);

        // б)
        int s = 3;
        int sIndex = s - 1;
        int sumColS = 0;
        for (int i = 0; i < rows; i++) sumColS += a[i, sIndex];
        Console.WriteLine("D3.1б (сумма " + s + "-го столбца): " + sumColS);

        // D3.2
        // а)
        int sumCol2 = 0;
        for (int i = 0; i < rows; i++) sumCol2 += a[i, 1];
        Console.WriteLine("D3.2а (сумма 2-го столбца): " + sumCol2);

        // б)
        int k = 3;
        int kIndex = k - 1;
        int sumRowK = 0;
        for (int j = 0; j < cols; j++) sumRowK += a[kIndex, j];
        Console.WriteLine("D3.2б (сумма " + k + "-й строки): " + sumRowK);

        // D3.3
        int[,] school = new int[11, 4];
        for (int i = 0; i < 11; i++)
            for (int j = 0; j < 4; j++)
                school[i, j] = 25 + i + j;
        int sumParallel5 = 0;
        for (int j = 0; j < 4; j++) sumParallel5 += school[4, j];
        Console.WriteLine("D3.3 (учеников в параллели 5-х классов): " + sumParallel5);

        // D3.4
        // а)
        int sumSqCol4 = 0;
        for (int i = 0; i < rows; i++) sumSqCol4 += a[i, 3] * a[i, 3];
        Console.WriteLine("D3.4а (сумма квадратов 4-го столбца): " + sumSqCol4);

        // б)
        int sumSqRowK = 0;
        for (int j = 0; j < cols; j++) sumSqRowK += a[kIndex, j] * a[kIndex, j];
        Console.WriteLine("D3.4б (сумма квадратов " + k + "-й строки): " + sumSqRowK);

        // D3.5
        // а)
        int sumSqRow2 = 0;
        for (int j = 0; j < cols; j++) sumSqRow2 += a[1, j] * a[1, j];
        Console.WriteLine("D3.5а (сумма квадратов 2-й строки): " + sumSqRow2);

        // б)
        int c = 2;
        int cIndex = c - 1;
        int sumSqColC = 0;
        for (int i = 0; i < rows; i++) sumSqColC += a[i, cIndex] * a[i, cIndex];
        Console.WriteLine("D3.5б (сумма квадратов " + c + "-го столбца): " + sumSqColC);

        // D3.6
        // а)
        double avgCol2 = (double)sumCol2 / rows;
        Console.WriteLine("D3.6а (среднее 2-го столбца): " + avgCol2);

        // б)
        double avgRowK = (double)sumRowK / cols;
        Console.WriteLine("D3.6б (среднее " + k + "-й строки): " + avgRowK);

        // D3.7
        // а)
        int n = 4;
        int nIndex = n - 1;
        double sumColN = 0;
        for (int i = 0; i < rows; i++) sumColN += a[i, nIndex];
        double avgColN = sumColN / rows;
        Console.WriteLine("D3.7а (среднее " + n + "-го столбца): " + avgColN);

        // б)
        double avgRow1 = 0;
        for (int j = 0; j < cols; j++) avgRow1 += a[0, j];
        avgRow1 /= cols;
        Console.WriteLine("D3.7б (среднее 1-й строки): " + avgRow1);
    }
}
