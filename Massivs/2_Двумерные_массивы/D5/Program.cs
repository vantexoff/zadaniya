using System;

class Program
{
    static void Main()
    {
        int[,] a = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);

        // D5.1
        // а)
        int prodCol2 = 1;
        for (int i = 0; i < rows; i++) prodCol2 *= a[i, 1];
        bool isThreeDigit = Math.Abs(prodCol2) >= 100 && Math.Abs(prodCol2) <= 999;
        Console.WriteLine("D5.1а: произведение 2-го столбца = " + prodCol2 + ", трёхзначное? " + isThreeDigit);

        // б)
        int knownRowNumber = 2;       
        int knownRowIndex = knownRowNumber - 1;
        int targetSum1 = 50;
        int sumRow = 0;
        for (int j = 0; j < cols; j++) sumRow += a[knownRowIndex, j];
        bool isSumGreater = sumRow > targetSum1;
        Console.WriteLine("D5.1б: сумма строки №" + knownRowNumber + " = " + sumRow +
            ", превышает " + targetSum1 + "? " + isSumGreater);

        // D5.2
        // а)
        int sumRow4 = 0;
        for (int j = 0; j < cols; j++) sumRow4 += a[3, j];
        bool isTwoDigit = Math.Abs(sumRow4) >= 10 && Math.Abs(sumRow4) <= 99;
        Console.WriteLine("D5.2а: сумма 4-й строки = " + sumRow4 + ", двузначное? " + isTwoDigit);

        // б)
        int knownColNumber = 2;         
        int knownColIndex = knownColNumber - 1; 
        int targetProd = 1000;
        int prodCol = 1;
        for (int i = 0; i < rows; i++) prodCol *= a[i, knownColIndex];
        bool isProdLessOrEqual = prodCol <= targetProd;
        Console.WriteLine("D5.2б: произведение столбца №" + knownColNumber + " = " + prodCol +
            ", не превышает " + targetProd + "? " + isProdLessOrEqual);

        // D5.3
        int[,] salary = new int[18, 12];
        for (int i = 0; i < 18; i++)
            for (int j = 0; j < 12; j++)
                salary[i, j] = 40000 + i * 500 + j * 100;

        int targetSalary = 500000;
        int sumSalary1 = 0;
        for (int j = 0; j < 12; j++) sumSalary1 += salary[0, j];
        bool isIncomeGreater = sumSalary1 > targetSalary;
        Console.WriteLine("D5.3: годовой доход 1-го человека = " + sumSalary1 +
            ", больше " + targetSalary + "? " + isIncomeGreater);

        // D5.4
        int[,] stores = new int[10, 12];
        for (int i = 0; i < 10; i++)
            for (int j = 0; j < 12; j++)
                stores[i, j] = 90000 + i * 1000 + j * 500;

        int targetSeptSum = 1000000;
        int sumSept = 0;
        for (int i = 0; i < 10; i++) sumSept += stores[i, 8];
        bool isSeptGreater = sumSept > targetSeptSum;
        Console.WriteLine("D5.4: доход фирмы в сентябре = " + sumSept +
            ", превысил " + targetSeptSum + "? " + isSeptGreater);

        // D5.5
        int[,] hall = new int[23, 40];
        for (int j = 0; j < 40; j++) hall[0, j] = 1;
        hall[0, 25] = 0;

        bool hasFreeSeats = false;
        for (int j = 0; j < 40; j++)
        {
            if (hall[0, j] == 0)
            {
                hasFreeSeats = true;
                break;
            }
        }
        Console.WriteLine("D5.5: свободные места в 1-м ряду есть? " + hasFreeSeats);
    }
}
