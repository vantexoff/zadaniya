using System;

class Program
{
    //1
    static double SumMaxMin(double a, double b, double c)
    {
        double max = Math.Max(a, Math.Max(b, c));
        double min = Math.Min(a, Math.Min(b, c));
        return max + min;
    }

    //2
    static int SumOfDivisors(int number)
    {
        int sum = 0;
        for (int d = 1; d <= number; d++)
            if (number % d == 0) sum += d;
        return sum;
    }

    static int MaxDivisorSumNumber(int n)
    {
        int bestNumber = 2;
        int bestSum = SumOfDivisors(2);
        for (int i = 3; i <= n; i++)
        {
            int s = SumOfDivisors(i);
            if (s > bestSum) { bestSum = s; bestNumber = i; }
        }
        return bestNumber;
    }

    //3
    static int Gcd(int a, int b)
    {
        a = Math.Abs(a); b = Math.Abs(b);
        while (b != 0) { int t = b; b = a % b; a = t; }
        return a;
    }

    static bool AreCoprime(int a, int b, int c)
    {
        return Gcd(Gcd(a, b), c) == 1;
    }

    //4
    static double GeometricMeanOfAbs(double a, double b, double c)
    {
        return Math.Pow(Math.Abs(a) * Math.Abs(b) * Math.Abs(c), 1.0 / 3.0);
    }

    static double ArithmeticMean(double x, double y)
    {
        return (x + y) / 2.0;
    }

    //5
    static double Trace(double[,] matrix)
    {
        int n = matrix.GetLength(0);
        double sum = 0;
        for (int i = 0; i < n; i++) sum += matrix[i, i];
        return sum;
    }

    static void Main()
    {
        //1
        Console.WriteLine(SumMaxMin(5, -2, 8));

        //2
        Console.WriteLine(MaxDivisorSumNumber(20));

        //3
        Console.WriteLine(AreCoprime(8, 15, 21));

        //4
        Console.WriteLine(GeometricMeanOfAbs(-3, 4, -5));
        Console.WriteLine(ArithmeticMean(-3, 4));
        Console.WriteLine(ArithmeticMean(-3, -5));
        Console.WriteLine(ArithmeticMean(4, -5));

        //5
        double[,] A = { { 1, 2 }, { 3, 4 } };
        double[,] B = { { 5, 0, 1 }, { 2, 6, 3 }, { 0, 4, 7 } };
        double c = Trace(A);
        double d = Trace(B);
        for (double x = 0; x <= 1.0 + 1e-9; x += 0.1)
            Console.WriteLine("{0:F2} {1:F3}", x, c * x * x + d);
    }
}