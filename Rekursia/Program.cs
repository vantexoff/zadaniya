using System;

class Program
{
    static void Main(string[] args)
    {
        //1
        Console.WriteLine("Задание 1");
        Console.Write("Введите эпсилон: ");
        double epsilon = double.Parse(Console.ReadLine());

        double SeriesSum(int termNumber, double minValue)
        {
            double term = 1 / Math.Pow(2, termNumber) + 1 / Math.Pow(3, termNumber);
            if (Math.Abs(term) < minValue)
                return 0;
            return term + SeriesSum(termNumber + 1, minValue);
        }

        Console.WriteLine("Сумма = " + SeriesSum(1, epsilon));
        Console.WriteLine();

        //2
        Console.WriteLine("Задание 2");
        Console.Write("Введите эпсилон: ");
        double accuracy = double.Parse(Console.ReadLine());

        double Element(int index)
        {
            if (index == 1)
                return -1;
            return Math.Pow(-1, index) * Element(index - 1) / 2;
        }

        int FindNumber(int candidate, double precision)
        {
            if (Math.Abs(Element(candidate) - Element(candidate - 1)) < precision)
                return candidate;
            return FindNumber(candidate + 1, precision);
        }

        int foundNumber = FindNumber(2, accuracy);
        Console.WriteLine("Наименьший номер n = " + foundNumber);
        for (int i = 1; i <= foundNumber; i++)
            Console.WriteLine("a" + i + " = " + Element(i));
        Console.WriteLine();

        //3
        Console.WriteLine("Задание 3");
        Console.Write("Введите N (N >= 3): ");
        int membersCount = int.Parse(Console.ReadLine());
        while (membersCount < 3)
        {
            Console.Write("N должно быть не меньше 3, введите снова: ");
            membersCount = int.Parse(Console.ReadLine());
        }

        double Member(int position)
        {
            if (position == 1)
                return -1;
            if (position == 2)
                return 1;
            return Math.Pow(-1, position) * Member(position - 1) / (2 * Member(position - 2));
        }

        double oddSum = 0;
        double evenProduct = 1;
        for (int j = 1; j <= membersCount; j++)
        {
            double memberValue = Member(j);
            Console.WriteLine("a" + j + " = " + memberValue);
            if (j % 2 == 1)
                oddSum += memberValue;
            else
                evenProduct *= memberValue;
        }
        Console.WriteLine("Сумма нечётных членов = " + oddSum);
        Console.WriteLine("Произведение чётных членов = " + evenProduct);
        Console.WriteLine();

        //dop1
        Console.WriteLine("Доп. задание 1");
        Console.Write("Введите n: ");
        int lastDegree = int.Parse(Console.ReadLine());

        double HalfPowersSum(int degree)
        {
            if (degree == 0)
                return 1;
            return Math.Pow(-1, degree) / Math.Pow(2, degree) + HalfPowersSum(degree - 1);
        }

        Console.WriteLine("S = " + HalfPowersSum(lastDegree));
        Console.WriteLine();

        //dop2
        Console.WriteLine("Доп. задание 2");
        Console.Write("Введите n: ");
        int lastNumber = int.Parse(Console.ReadLine());

        long SeventhPowersSum(int number)
        {
            if (number == 0)
                return 0;
            return (long)Math.Pow(number, 7) + SeventhPowersSum(number - 1);
        }

        Console.WriteLine("S = " + SeventhPowersSum(lastNumber));
        Console.WriteLine();

        //dop3
        Console.WriteLine("Доп. задание 3");
        Console.Write("Введите x: ");
        double x = double.Parse(Console.ReadLine());

        double Factorial(int factor)
        {
            if (factor <= 1)
                return 1;
            return factor * Factorial(factor - 1);
        }

        double TaylorSum(int termIndex, double argument)
        {
            int power = 2 * termIndex + 1;
            double taylorTerm = Math.Pow(-1, termIndex) * Math.Pow(argument, power) / Factorial(power);
            if (termIndex == 0)
                return taylorTerm;
            return taylorTerm + TaylorSum(termIndex - 1, argument);
        }

        Console.WriteLine("Результат = " + TaylorSum(6, x));
        Console.WriteLine();

        //dop4
        Console.WriteLine("Доп. задание 4");
        Console.Write("Введите n: ");
        int squaresCount = int.Parse(Console.ReadLine());

        double InverseSquaresSum(int k)
        {
            if (k == 0)
                return 0;
            return 1 / Math.Pow(2 * k + 1, 2) + InverseSquaresSum(k - 1);
        }

        Console.WriteLine("S = " + InverseSquaresSum(squaresCount));
        Console.WriteLine();

        //dop5
        Console.WriteLine("Доп. задание 5");

        double SinSum(int step)
        {
            if (step > 10)
                return 0;
            return Math.Sin(1 + step * 0.1) + SinSum(step + 1);
        }

        double y = SinSum(0);
        Console.WriteLine("y = " + y);
        Console.WriteLine();

        //dop6
        Console.WriteLine("Доп. задание 6");
        Console.Write("Введите x: ");
        double xPoly = double.Parse(Console.ReadLine());

        double Horner(int coefficient, double point)
        {
            if (coefficient == 1)
                return 1;
            return Horner(coefficient - 1, point) * point + coefficient;
        }

        Console.WriteLine("Результат = " + Horner(11, xPoly));
        Console.WriteLine();

        //dop7
        Console.WriteLine("Доп. задание 7");
        Console.Write("Введите n: ");
        int sinTimes = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите x: ");
        double sinStart = double.Parse(Console.ReadLine());

        double NestedSinSum(int sinLeft, double previousSin)
        {
            if (sinLeft == 0)
                return 0;
            double nextSin = Math.Sin(previousSin);
            return nextSin + NestedSinSum(sinLeft - 1, nextSin);
        }

        Console.WriteLine("S = " + NestedSinSum(sinTimes, sinStart));
        Console.WriteLine();

        //dop8
        Console.WriteLine("Доп. задание 8");
        Console.Write("Введите N (N > 2): ");
        int cosLimit = int.Parse(Console.ReadLine());
        while (cosLimit <= 2)
        {
            Console.Write("N должно быть больше 2, введите снова: ");
            cosLimit = int.Parse(Console.ReadLine());
        }

        double CosSum(int cosArgument)
        {
            if (cosArgument == 0)
                return 0;
            return Math.Cos(cosArgument) + CosSum(cosArgument - 1);
        }

        Console.WriteLine("S = " + CosSum(cosLimit));
        Console.WriteLine();

        //dop9
        Console.WriteLine("Доп. задание 9");
        Console.Write("Введите N (N > 2): ");
        int sinLimit = int.Parse(Console.ReadLine());
        while (sinLimit <= 2)
        {
            Console.Write("N должно быть больше 2, введите снова: ");
            sinLimit = int.Parse(Console.ReadLine());
        }

        double SinProduct(int sinArgument)
        {
            if (sinArgument == 1)
                return Math.Sin(1);
            return Math.Sin(sinArgument) * SinProduct(sinArgument - 1);
        }

        Console.WriteLine("P = " + SinProduct(sinLimit));
        Console.WriteLine();

        //dop10
        Console.WriteLine("Доп. задание 10");
        Console.Write("Введите начальный вес пациента: ");
        double startWeight = double.Parse(Console.ReadLine());

        int FastingDays(double currentWeight, double initialWeight)
        {
            if (currentWeight <= initialWeight / 2)
                return 0;
            return 1 + FastingDays(currentWeight * 0.99, initialWeight);
        }

        Console.WriteLine("Вес снизится в два раза через " + FastingDays(startWeight, startWeight) + " дней");
        Console.WriteLine();

        //dop11
        Console.WriteLine("Доп. задание 11");
        Console.Write("Введите цену платья A: ");
        double priceA = double.Parse(Console.ReadLine());

        int MarkdownDays(double currentPrice, double initialPrice)
        {
            if (currentPrice <= initialPrice / 2)
                return 0;
            return 15 + MarkdownDays(currentPrice * 0.95, initialPrice);
        }

        Console.WriteLine("Цена снизится в два раза через " + MarkdownDays(priceA, priceA) + " дней");
        Console.WriteLine();

        //dop12
        Console.WriteLine("Доп. задание 12");
        Console.Write("Введите n: ");
        int cosTimes = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите x: ");
        double cosStart = double.Parse(Console.ReadLine());

        double NestedCosProduct(int cosLeft, double previousCos)
        {
            if (cosLeft == 0)
                return 1;
            double nextCos = Math.Cos(previousCos);
            return nextCos * NestedCosProduct(cosLeft - 1, nextCos);
        }

        Console.WriteLine("S = " + NestedCosProduct(cosTimes, cosStart));
    }
}
