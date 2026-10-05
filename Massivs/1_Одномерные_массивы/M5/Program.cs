using System;

class Program
{
    static void PrintArray(string label, int[] arr)
    {
        Console.WriteLine($"{label}: [{string.Join(", ", arr)}]");
    }

    static void PrintArray(string label, double[] arr)
    {
        Console.WriteLine($"{label}: [{string.Join(", ", arr)}]");
    }

    static void Main()
    {
        Random rnd = new Random(1);

        // M5.1
        Console.WriteLine("=== M5.1 ===");
        int[] arr = { 12, 5, 80, 3, 45, 80, 3 };
        PrintArray("Массив", arr);
        int max = arr[0], min = arr[0], maxIdx = 0, minIdx = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max) { max = arr[i]; maxIdx = i; }
            if (arr[i] < min) { min = arr[i]; minIdx = i; }
        }
        int diff = max - min;
        Console.WriteLine($"а) Максимальный элемент: {max}");
        Console.WriteLine($"б) Минимальный элемент: {min}");
        Console.WriteLine($"в) Максимальный больше минимального на: {diff}");
        Console.WriteLine($"г) Индекс максимального элемента: {maxIdx}");
        Console.WriteLine($"д) Индекс минимального элемента: {minIdx}, индекс максимального элемента: {maxIdx}");

        // M5.2
        Console.WriteLine("\n=== M5.2 ===");
        int[] cars = new int[50];
        for (int i = 0; i < cars.Length; i++) cars[i] = rnd.Next(300000, 5000000);
        PrintArray("Стоимости 50 марок автомобилей", cars);
        int maxCar = cars[0];
        for (int i = 1; i < cars.Length; i++) if (cars[i] > maxCar) maxCar = cars[i];
        Console.WriteLine($"Стоимость самого дорогого автомобиля: {maxCar}");

        // M5.3
        Console.WriteLine("\n=== M5.3 ===");
        int[] candy = new int[20];
        for (int i = 0; i < candy.Length; i++) candy[i] = rnd.Next(100, 2000);
        PrintArray("Стоимости 1 кг для 20 видов конфет", candy);
        int minCandy = candy[0];
        for (int i = 1; i < candy.Length; i++) if (candy[i] < minCandy) minCandy = candy[i];
        Console.WriteLine($"Стоимость самых дешевых конфет: {minCandy}");

        // M5.4
        Console.WriteLine("\n=== M5.4 ===");
        int[] height = new int[25];
        for (int i = 0; i < height.Length; i++) height[i] = rnd.Next(150, 200);
        PrintArray("Рост 25 человек", height);
        int maxH = height[0], minH = height[0];
        for (int i = 1; i < height.Length; i++)
        {
            if (height[i] > maxH) maxH = height[i];
            if (height[i] < minH) minH = height[i];
        }
        int diffH = maxH - minH;
        Console.WriteLine($"Рост самого высокого превышает рост самого низкого на: {diffH}");

        // M5.5
        Console.WriteLine("\n=== M5.5 ===");
        double[] scores = { 5.8, 6.0, 5.5, 5.9, 5.7, 6.0, 5.4, 5.8 };
        PrintArray("Оценки восьми судей", scores);
        double sMax = scores[0], sMin = scores[0], total = 0;
        for (int i = 0; i < scores.Length; i++)
        {
            if (scores[i] > sMax) sMax = scores[i];
            if (scores[i] < sMin) sMin = scores[i];
            total += scores[i];
        }
        double finalScore = (total - sMax - sMin) / (scores.Length - 2);
        Console.WriteLine($"Зачетная оценка спортсмена (без одной макс. и одной мин. оценки): {finalScore}");
    }
}
