using System;

class Program
{
    static void Main()
    {
        // Базовый массив для M2.1, M2.3, M2.4, M2.5
        double[] baseArr = { 4, 9, 16, 25, 36, 49, 64, 81 };
        int[] intArr = { 10, -5, 8, 14, 3 };

        // M2.1
        // а) 
        Console.WriteLine($"M2.1а: sqrt(arr[3]) = {Math.Sqrt(baseArr[3])}");

        // б)
        Console.WriteLine($"M2.1б: (arr[0]+arr[4])/2 = {(baseArr[0] + baseArr[4]) / 2.0}");

        // M2.2
        int s = 1, k = 2;
        Console.WriteLine($"M2.2а: intArr[{s}] ({intArr[s]}) положительный? {intArr[s] > 0}");
        Console.WriteLine($"M2.2б: intArr[{k}] ({intArr[k]}) четный? {intArr[k] % 2 == 0}");
        Console.WriteLine(intArr[k] > intArr[s]
            ? $"M2.2в: k-й элемент ({intArr[k]}) больше s-го ({intArr[s]})"
            : $"M2.2в: s-й элемент ({intArr[s]}) больше или равен k-му ({intArr[k]})");

        // M2.3
        double A = 3;

        double[] m23a = (double[])baseArr.Clone();
        for (int i = 0; i < m23a.Length; i++) m23a[i] *= 2;
        Console.WriteLine("M2.3а (все элементы * 2): " + string.Join(" ", m23a));

        double[] m23b = (double[])baseArr.Clone();
        for (int i = 0; i < m23b.Length; i++) m23b[i] -= A;
        Console.WriteLine($"M2.3б (все элементы - A({A})): " + string.Join(" ", m23b));

        double[] m23v = (double[])baseArr.Clone();
        double firstEl = m23v[0];
        for (int i = 0; i < m23v.Length; i++) m23v[i] /= firstEl;
        Console.WriteLine("M2.3в (все элементы / первый элемент): " + string.Join(" ", m23v));

        // M2.4
        double B = 5;

        double[] m24a = (double[])baseArr.Clone();
        for (int i = 0; i < m24a.Length; i++) m24a[i] -= 20;
        Console.WriteLine("M2.4а (все элементы - 20): " + string.Join(" ", m24a));

        double[] m24b = (double[])baseArr.Clone();
        double lastEl = m24b[m24b.Length - 1];
        for (int i = 0; i < m24b.Length; i++) m24b[i] *= lastEl;
        Console.WriteLine("M2.4б (все элементы * последний элемент): " + string.Join(" ", m24b));

        double[] m24v = (double[])baseArr.Clone();
        for (int i = 0; i < m24v.Length; i++) m24v[i] += B;
        Console.WriteLine($"M2.4в (все элементы + B({B})): " + string.Join(" ", m24v));

        // M2.5
        double sum = 0, prod = 1, sumSq = 0, sum6 = 0;
        for (int i = 0; i < baseArr.Length; i++)
        {
            sum += baseArr[i];
            prod *= baseArr[i];
            sumSq += baseArr[i] * baseArr[i];
            if (i < 6) sum6 += baseArr[i];
        }
        Console.WriteLine($"M2.5а: сумма всех элементов = {sum}");
        Console.WriteLine($"M2.5б: произведение всех элементов = {prod}");
        Console.WriteLine($"M2.5в: сумма квадратов всех элементов = {sumSq}");
        Console.WriteLine($"M2.5г: сумма первых шести элементов = {sum6}");

        Console.Write("Введите k1 и k2 (нумерация с 1, k2 > k1). k1 = ");
        int k1 = int.Parse(Console.ReadLine() ?? "");
        Console.Write("k2 = ");
        int k2 = int.Parse(Console.ReadLine() ?? "");
        double sumK = 0;
        for (int i = k1 - 1; i <= k2 - 1; i++) sumK += baseArr[i];
        Console.WriteLine($"M2.5д: сумма элементов с {k1}-го по {k2}-й = {sumK}");

        double avg = sum / baseArr.Length;
        Console.WriteLine($"M2.5е: среднее арифметическое всех элементов = {avg}");

        Console.Write("Введите s1 и s2 (нумерация с 1, s2 > s1). s1 = ");
        int s1 = int.Parse(Console.ReadLine() ?? "");
        Console.Write("s2 = ");
        int s2 = int.Parse(Console.ReadLine() ?? "");
        double sumS = 0;
        for (int i = s1 - 1; i <= s2 - 1; i++) sumS += baseArr[i];
        double avgS = sumS / (s2 - s1 + 1);
        Console.WriteLine($"M2.5ж: среднее арифметическое элементов с {s1}-го по {s2}-й = {avgS}");
    }
}
