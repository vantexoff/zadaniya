using System;

class Program
{
    static void Main()
    {
        int[,] a = {
            { 1, 2, 3, 4, 5 },
            { 6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 },
            { 16, 17, 18, 19, 20 },
            { 21, 22, 23, 24, 25 }
        };
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);

        // D4.1
        // а)
        int maxCol3 = a[0, 2];
        for (int i = 1; i < rows; i++)
            if (a[i, 2] > maxCol3) maxCol3 = a[i, 2];
        Console.WriteLine("D4.1а (максимум 3-го столбца): " + maxCol3);

        // б)
        int minRow2 = a[1, 0];
        for (int j = 1; j < cols; j++)
            if (a[1, j] < minRow2) minRow2 = a[1, j];
        Console.WriteLine("D4.1б (минимум 2-й строки): " + minRow2);

        // D4.2
        // а)
        int maxRow5 = a[4, 0];
        for (int j = 1; j < cols; j++)
            if (a[4, j] > maxRow5) maxRow5 = a[4, j];
        Console.WriteLine("D4.2а (максимум 5-й строки): " + maxRow5);

        // б)
        int minCol4 = a[0, 3];
        for (int i = 1; i < rows; i++)
            if (a[i, 3] < minCol4) minCol4 = a[i, 3];
        Console.WriteLine("D4.2б (минимум 4-го столбца): " + minCol4);

        // D4.3
        // а)
        int r = 2;
        int minAnyRow = a[r, 0];
        for (int j = 1; j < cols; j++)
            if (a[r, j] < minAnyRow) minAnyRow = a[r, j];
        Console.WriteLine("D4.3а (минимум строки №" + (r + 1) + "): " + minAnyRow);

        // б)
        int c = 1;
        int maxAnyCol = a[0, c];
        for (int i = 1; i < rows; i++)
            if (a[i, c] > maxAnyCol) maxAnyCol = a[i, c];
        Console.WriteLine("D4.3б (максимум столбца №" + (c + 1) + "): " + maxAnyCol);

        // D4.4
        // а)
        int maxAnyRow = a[r, 0];
        for (int j = 1; j < cols; j++)
            if (a[r, j] > maxAnyRow) maxAnyRow = a[r, j];
        Console.WriteLine("D4.4а (максимум строки №" + (r + 1) + "): " + maxAnyRow);

        // б)
        int minAnyCol = a[0, c];
        for (int i = 1; i < rows; i++)
            if (a[i, c] < minAnyCol) minAnyCol = a[i, c];
        Console.WriteLine("D4.4б (минимум столбца №" + (c + 1) + "): " + minAnyCol);

        // D4.5
        // а)
        int minColIdx = 0;
        for (int j = 1; j < cols; j++)
            if (a[3, j] < a[3, minColIdx]) minColIdx = j;
        Console.WriteLine("D4.5а (номер столбца минимума 4-й строки, самый левый): " + (minColIdx + 1));

        // б)
        int maxRowIdx = 0;
        for (int i = 1; i < rows; i++)
            if (a[i, 2] >= a[maxRowIdx, 2]) maxRowIdx = i;
        Console.WriteLine("D4.5б (номер строки максимума 3-го столбца, самый нижний): " + (maxRowIdx + 1));
    }
}
