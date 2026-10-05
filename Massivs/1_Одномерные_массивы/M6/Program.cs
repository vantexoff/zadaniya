using System;

class Program
{
    static int[] Clone(int[] a) => (int[])a.Clone();

    static void PrintArray(string label, int[] arr)
    {
        Console.WriteLine($"{label}: [{string.Join(", ", arr)}]");
    }

    static int ReadInt(string prompt)
    {
        Console.Write(prompt);
        return int.Parse(Console.ReadLine() ?? "0");
    }

    static void Main()
    {
        int temp;

        // M6.1
        Console.WriteLine("=== M6.1 ===");
        int[] baseArr1 = { 10, 20, 5, 40, 5, 80, 30, 80 };
        PrintArray("Исходный массив", baseArr1);

        // а)
        int[] a1a = Clone(baseArr1);
        temp = a1a[1]; a1a[1] = a1a[4]; a1a[4] = temp;
        PrintArray("а) после обмена 2-го и 5-го элементов", a1a);

        // б)
        int m = ReadInt($"Введите номер m элемента (1..{baseArr1.Length}): ") - 1;
        int n = ReadInt($"Введите номер n элемента (1..{baseArr1.Length}): ") - 1;
        int[] a1b = Clone(baseArr1);
        temp = a1b[m]; a1b[m] = a1b[n]; a1b[n] = temp;
        PrintArray($"б) после обмена {m + 1}-го и {n + 1}-го элементов", a1b);

        // в)
        int[] a1v = Clone(baseArr1);
        int maxIdx = 0;
        for (int i = 1; i < a1v.Length; i++)
            if (a1v[i] > a1v[maxIdx]) maxIdx = i;
        temp = a1v[2]; a1v[2] = a1v[maxIdx]; a1v[maxIdx] = temp;
        PrintArray("в) после обмена 3-го и максимального элементов", a1v);

        // г)
        int[] a1g = Clone(baseArr1);
        int minIdx = 0;
        for (int i = 1; i < a1g.Length; i++)
            if (a1g[i] <= a1g[minIdx]) minIdx = i;
        temp = a1g[0]; a1g[0] = a1g[minIdx]; a1g[minIdx] = temp;
        PrintArray("г) после обмена 1-го и минимального элементов", a1g);

        // M6.2
        Console.WriteLine("\n=== M6.2 ===");
        int[] baseArr2 = { 1, 2, 3, 4, 5, 6 };
        PrintArray("Исходный массив", baseArr2);
        int half = baseArr2.Length / 2;

        // а)
        int[] a2a = Clone(baseArr2);
        for (int i = 0; i < half; i++)
        {
            temp = a2a[i]; a2a[i] = a2a[i + half]; a2a[i + half] = temp;
        }
        PrintArray("а) после обмена половин", a2a);

        // б)
        int[] a2b = Clone(baseArr2);
        for (int i = 0; i < a2b.Length - 1; i += 2)
        {
            temp = a2b[i]; a2b[i] = a2b[i + 1]; a2b[i + 1] = temp;
        }
        PrintArray("б) после обмена соседних пар", a2b);

        // в)
        int[] a2v = Clone(baseArr2);
        for (int i = 0; i < half; i++)
        {
            temp = a2v[i]; a2v[i] = a2v[a2v.Length - 1 - i]; a2v[a2v.Length - 1 - i] = temp;
        }
        PrintArray("в) после зеркального обмена половин", a2v);

        // M6.3
        Console.WriteLine("\n=== M6.3 ===");
        int[] baseArr3 = { 10, 20, 30, 40, 50, 60 };
        PrintArray("Исходный массив", baseArr3);

        // а)
        int[] a3a = Clone(baseArr3);
        for (int i = 2; i < a3a.Length - 1; i++) a3a[i] = a3a[i + 1];
        a3a[a3a.Length - 1] = 0;
        PrintArray("а) после удаления 3-го элемента", a3a);

        // б)
        int k = ReadInt($"Введите номер k удаляемого элемента (1..{baseArr3.Length}): ") - 1;
        int[] a3b = Clone(baseArr3);
        for (int i = k; i < a3b.Length - 1; i++) a3b[i] = a3b[i + 1];
        a3b[a3b.Length - 1] = 0;
        PrintArray($"б) после удаления {k + 1}-го элемента", a3b);

        // M6.4
        Console.WriteLine("\n=== M6.4 ===");
        Random rnd = new Random(1);
        int[] prices = new int[20];
        for (int i = 0; i < prices.Length; i++) prices[i] = rnd.Next(100, 5000);
        PrintArray("Стоимости 20 видов товара", prices);
        int nDel = ReadInt($"Введите номер n товара, снимаемого с продажи (1..{prices.Length}): ") - 1;
        int[] remaining = Clone(prices);
        for (int i = nDel; i < remaining.Length - 1; i++) remaining[i] = remaining[i + 1];
        remaining[remaining.Length - 1] = 0;
        PrintArray("Оставшиеся товары (последний элемент обнулён)", remaining);

        // M6.5
        Console.WriteLine("\n=== M6.5 ===");
        int[] baseArr5 = { 15, 2, 8, 20, 5 };
        PrintArray("Исходный массив (все элементы различны)", baseArr5);
        int mxIdx = 0, mnIdx = 0;
        for (int i = 1; i < baseArr5.Length; i++)
        {
            if (baseArr5[i] > baseArr5[mxIdx]) mxIdx = i;
            if (baseArr5[i] < baseArr5[mnIdx]) mnIdx = i;
        }

        // а)
        int[] a5a = Clone(baseArr5);
        for (int i = mxIdx; i < a5a.Length - 1; i++) a5a[i] = a5a[i + 1];
        a5a[a5a.Length - 1] = 0;
        PrintArray("а) после удаления максимального элемента", a5a);

        // б)
        int[] a5b = Clone(baseArr5);
        for (int i = mnIdx; i < a5b.Length - 1; i++) a5b[i] = a5b[i + 1];
        a5b[a5b.Length - 1] = 0;
        PrintArray("б) после удаления минимального элемента", a5b);

        // M6.6
        Console.WriteLine("\n=== M6.6 ===");
        int[] baseArr6 = { 1, -5, 3, 4, 8, 7 };
        PrintArray("Исходный массив", baseArr6);

        // а)
        int insertIdx = 1;
        int[] res6a = new int[baseArr6.Length + 1];
        for (int i = 0; i <= insertIdx; i++) res6a[i] = baseArr6[i];
        res6a[insertIdx + 1] = 10;
        for (int i = insertIdx + 1; i < baseArr6.Length; i++) res6a[i + 1] = baseArr6[i];
        PrintArray("а) после вставки 10 после 2-го элемента", res6a);

        // б)
        int mIns = ReadInt($"Введите номер m элемента, после которого вставить 100 (1..{baseArr6.Length}): ") - 1;
        int[] res6b = new int[baseArr6.Length + 1];
        for (int i = 0; i <= mIns; i++) res6b[i] = baseArr6[i];
        res6b[mIns + 1] = 100;
        for (int i = mIns + 1; i < baseArr6.Length; i++) res6b[i + 1] = baseArr6[i];
        PrintArray($"б) после вставки 100 после {mIns + 1}-го элемента", res6b);

        // M6.7
        Console.WriteLine("\n=== M6.7 ===");
        PrintArray("Исходный массив", baseArr6);
        int numToInsert = ReadInt("Введите заданное число для вставки: ");

        // а)
        int firstNegIdx = -1;
        for (int i = 0; i < baseArr6.Length; i++)
        {
            if (baseArr6[i] < 0) { firstNegIdx = i; break; }
        }
        if (firstNegIdx != -1)
        {
            int[] res7a = new int[baseArr6.Length + 1];
            for (int i = 0; i <= firstNegIdx; i++) res7a[i] = baseArr6[i];
            res7a[firstNegIdx + 1] = numToInsert;
            for (int i = firstNegIdx + 1; i < baseArr6.Length; i++) res7a[i + 1] = baseArr6[i];
            PrintArray("а) после вставки числа после первого отрицательного элемента", res7a);
        }
        else
        {
            Console.WriteLine("а) отрицательных элементов нет");
        }

        // б)
        int lastEvenIdx = -1;
        for (int i = baseArr6.Length - 1; i >= 0; i--)
        {
            if (baseArr6[i] % 2 == 0) { lastEvenIdx = i; break; }
        }
        if (lastEvenIdx != -1)
        {
            int[] res7b = new int[baseArr6.Length + 1];
            for (int i = 0; i < lastEvenIdx; i++) res7b[i] = baseArr6[i];
            res7b[lastEvenIdx] = numToInsert;
            for (int i = lastEvenIdx; i < baseArr6.Length; i++) res7b[i + 1] = baseArr6[i];
            PrintArray("б) после вставки числа перед последним четным элементом", res7b);
        }
        else
        {
            Console.WriteLine("б) четных элементов нет");
        }
    }
}
