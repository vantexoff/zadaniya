using System;

class Program
{
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
        int[] arr = { 10, 5, 70000, 5, 20, 30, 0, 40, 70001, 0, 50 };
        PrintArray("Массив", arr);

        // M7.1
        Console.WriteLine("\n=== M7.1 ===");
        int first5 = Array.IndexOf(arr, 5);
        int last5 = Array.LastIndexOf(arr, 5);
        Console.WriteLine($"а) Номер первого элемента, равного 5: {first5}");
        Console.WriteLine($"б) Номер последнего элемента, равного 5: {last5}");

        // M7.2
        Console.WriteLine("\n=== M7.2 ===");
        int firstBig = Array.FindIndex(arr, x => x > 65530);
        int lastBig = Array.FindLastIndex(arr, x => x > 65530);
        Console.WriteLine($"а) Номер первого элемента, большего 65530: {firstBig}");
        Console.WriteLine($"б) Номер последнего элемента, большего 65530: {lastBig}");

        // M7.3
        Console.WriteLine("\n=== M7.3 ===");
        int firstZero = Array.IndexOf(arr, 0);
        int lastZero = Array.LastIndexOf(arr, 0);
        Console.Write("а) Все элементы, кроме первого нулевого: ");
        for (int i = 0; i < arr.Length; i++)
            if (i != firstZero) Console.Write(arr[i] + " ");
        Console.WriteLine();
        Console.Write("б) Все элементы, кроме последнего нулевого: ");
        for (int i = 0; i < arr.Length; i++)
            if (i != lastZero) Console.Write(arr[i] + " ");
        Console.WriteLine();

        // M7.4
        Console.WriteLine("\n=== M7.4 ===");
        int[] sorted = { 10, 20, 30, 40, 50, 60 };
        PrintArray("Отсортированный по возрастанию массив", sorted);
        int numA = ReadInt($"Введите число a (не равно ни одному элементу, больше {sorted[0]} и меньше {sorted[sorted.Length - 1]}): ");
        int idxLess = Array.FindIndex(sorted, x => x > numA);

        Console.Write("а) Элементы массива, меньшие a: ");
        for (int i = 0; i < idxLess; i++) Console.Write(sorted[i] + " ");
        Console.WriteLine();

        int leftIdx = idxLess - 1, rightIdx = idxLess;
        int left = sorted[leftIdx], right = sorted[rightIdx];
        Console.WriteLine($"б) a находится между элементом №{leftIdx} (значение {left}) и элементом №{rightIdx} (значение {right})");

        int nearestIdx = (numA - left <= right - numA) ? leftIdx : rightIdx;
        Console.WriteLine($"в) Ближайший к a элемент: №{nearestIdx}, значение {sorted[nearestIdx]}");

        // M7.5
        Console.WriteLine("\n=== M7.5 ===");
        int[] heights = { 190, 185, 180, 175, 170, 165 };
        PrintArray("Рост 15... (демо) учеников класса, по убыванию", heights);
        int newHeight = ReadInt($"Введите рост нового ученика (больше {heights[heights.Length - 1]} и меньше {heights[0]}): ");
        int place = Array.FindIndex(heights, h => h < newHeight) + 1;
        Console.WriteLine($"Новый ученик займёт место №{place} в списке роста");
    }
}
