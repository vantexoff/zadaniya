using System;

class Program
{
    static void Main()
    {
        // D6.1
        int[,] arr1 = {
            { 1,  2,  3 },
            { 4,  5,  6 },
            { 7,  8,  9 },
            { 10, 11, 12 },
            { 13, 20, 13 }
        };
        int row1 = 4;
        int target1 = 13;
        int leftCol = -1;
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            if (arr1[row1, j] == target1)
            {
                leftCol = j;
                break;
            }
        }
        Console.Write("D6.1: ");
        if (leftCol != -1)
            Console.WriteLine($"самый левый элемент, равный {target1}, в 5-й строке находится в столбце №{leftCol + 1}");
        else
            Console.WriteLine($"в 5-й строке нет элементов, равных {target1}");

        // D6.2
        int[,] arr2 = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 0, 9, 0, 10 } 
        };
        int row2 = 2;
        int target2 = 0;
        int rightCol = -1;
        for (int j = arr2.GetLength(1) - 1; j >= 0; j--)
        {
            if (arr2[row2, j] == target2)
            {
                rightCol = j;
                break;
            }
        }
        Console.Write("D6.2: ");
        if (rightCol != -1)
            Console.WriteLine($"самый правый элемент, равный {target2}, в 3-й строке находится в столбце №{rightCol + 1}");
        else
            Console.WriteLine($"в 3-й строке нет элементов, равных {target2}");

        // D6.3
        int[,] arr3 = {
            { 1, 21 },
            { 2, 5 },
            { 3, 21 },
            { 4, 6 }
        };
        int col3 = 1;
        int target3 = 21;
        int topRow = -1;
        for (int i = 0; i < arr3.GetLength(0); i++)
        {
            if (arr3[i, col3] == target3)
            {
                topRow = i;
                break;
            }
        }
        Console.Write("D6.3: ");
        if (topRow != -1)
            Console.WriteLine($"самый верхний элемент, равный {target3}, во 2-м столбце находится в строке №{topRow + 1}");
        else
            Console.WriteLine($"во 2-м столбце нет элементов, равных {target3}");

        // D6.4
        int[,] arr4 = {
            { 1, 10 },
            { 2, 5 },
            { 3, 10 },
            { 4, 6 }
        };
        int col4 = 1; 
        int target4 = 10;
        int bottomRow = -1;
        for (int i = arr4.GetLength(0) - 1; i >= 0; i--)
        {
            if (arr4[i, col4] == target4)
            {
                bottomRow = i;
                break;
            }
        }
        Console.Write("D6.4: ");
        if (bottomRow != -1)
            Console.WriteLine($"самый нижний элемент, равный {target4}, во 2-м столбце находится в строке №{bottomRow + 1}");
        else
            Console.WriteLine($"во 2-м столбце нет элементов, равных {target4}");

        // D6.5
        // а)
        int[,] arr5 = {
            { 1, 2, 3 },
            { 4, 7, 6 },
            { 7, 8, 9 }
        };
        int checkRow = 1;    
        int givenNumber = 7; 
        bool found5a = false;
        Console.Write("D6.5 а): ");
        for (int j = 0; j < arr5.GetLength(1); j++)
        {
            if (arr5[checkRow, j] == givenNumber)
            {
                Console.WriteLine($"в строке №{checkRow + 1} найден элемент, равный {givenNumber}, координаты (строка {checkRow + 1}, столбец {j + 1})");
                found5a = true;
                break;
            }
        }
        if (!found5a)
            Console.WriteLine($"в строке №{checkRow + 1} нет элемента, равного {givenNumber}");

        // б)
        int[,] arr6 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        int checkCol = 2;
        int divisor = 3;   
        bool found5b = false;
        Console.Write("D6.5 б): ");
        for (int i = 0; i < arr6.GetLength(0); i++)
        {
            if (arr6[i, checkCol] % divisor == 0)
            {
                Console.WriteLine($"в столбце №{checkCol + 1} найден элемент, кратный {divisor}, координаты (строка {i + 1}, столбец {checkCol + 1})");
                found5b = true;
                break;
            }
        }
        if (!found5b)
            Console.WriteLine($"в столбце №{checkCol + 1} нет элемента, кратного {divisor}");
    }
}
