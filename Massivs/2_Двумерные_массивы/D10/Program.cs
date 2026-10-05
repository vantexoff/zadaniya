using System;

class Program
{
    static void Main()
    {
        char[,] chars = {
            { 'a', 'b', 'c', 'd', 'e' },
            { 'f', 'g', 'h', 'i', 'j' },
            { 'k', 'l', 'm', 'n', 'o' },
            { 'p', 'q', 'r', 's', 't' }
        };
        int rows = chars.GetLength(0);
        int cols = chars.GetLength(1);

        // D10.1
        Console.Write("D10.1: ");
        Console.WriteLine("" + chars[0, 0] + chars[0, cols - 1] + chars[rows - 1, 0] + chars[rows - 1, cols - 1]);      

        // D10.2
        int targetRow = 1; 
        int startCol = 1; 
        int endCol = 3; 

        Console.Write("D10.2: ");
        for (int j = startCol; j <= endCol; j++)
        {
            Console.Write(chars[targetRow, j]);
        }
        Console.WriteLine();

        // D10.3
        char[,] grid = {
            { 'H', 'e', 'l', 'l', 'o' },
            { 'W', 'o', 'r', 'l', 'd' },
            { 'A', 'B', 'C', 'D', 'E' },
            { 'F', 'G', 'H', 'I', 'J' },
            { 'K', 'L', 'M', 'N', 'O' }
        };

        bool[,] starMask = {
            { true, false, false, false, true },
            { false, true, false, true, false },
            { false, false, true, false, false },
            { false, true, false, true, false },
            { true, false, false, false, true }
        };

        Console.Write("D10.3 а) Слева направо по строкам: ");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (starMask[i, j]) Console.Write(grid[i, j]);
            }
        }
        Console.WriteLine();

        Console.Write("D10.3 б) Сверху вниз по столбцам: ");
        for (int j = 0; j < 5; j++)
        {
            for (int i = 0; i < 5; i++)
            {
                if (starMask[i, j]) Console.Write(grid[i, j]);
            }
        }
        Console.WriteLine();

        // D10.4
        Console.WriteLine("D10.4 Четные элементы каждой строки:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 1; j < cols; j += 2)
            {
                Console.Write(chars[i, j]);
            }
            Console.WriteLine();
        }

        // D10.5
        string[,] triArr = {
            { "sun", "mon", "car" },
            { "---", "---", "---" },
            { "day", "key", "pet" },
            { "---", "---", "---" }
        };
        int triRows = triArr.GetLength(0);
        int triCols = triArr.GetLength(1);

        Console.WriteLine("D10.5 Слова из нечетных (по номеру) элементов каждого столбца (массив трёхсимвольных величин):");
        for (int j = 0; j < triCols; j++)
        {
            string word = "";
            for (int i = 0; i < triRows; i += 2)
            {
                word += triArr[i, j];
            }
            Console.WriteLine($"  Столбец {j + 1}: {word}");
        }
    }
}