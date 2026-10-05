using System;

class Program
{
    static void PrintArray(string label, double[] arr)
    {
        Console.WriteLine($"{label}: [{string.Join(", ", Array.ConvertAll(arr, x => x.ToString("F1")))}]");
    }

    static void Main()
    {
        Random rnd = new Random(1);

        // M8.1
        Console.WriteLine("=== M8.1 ===");
        double[] shop1 = new double[62];
        double[] shop2 = new double[62];
        for (int i = 0; i < 62; i++) { shop1[i] = rnd.Next(1000, 50000); shop2[i] = rnd.Next(1000, 50000); }
        double totalSales = 0;
        for (int i = 0; i < 62; i++) totalSales += shop1[i] + shop2[i];
        Console.WriteLine($"Общая стоимость товаров, проданных фирмой за июль и август: {totalSales}");

        // M8.2
        Console.WriteLine("\n=== M8.2 ===");
        int[] champ1 = new int[26];
        int[] champ2 = new int[26];
        for (int i = 0; i < 26; i++) { champ1[i] = rnd.Next(0, 6); champ2[i] = rnd.Next(0, 6); }
        int totalGoals = 0;
        for (int i = 0; i < 26; i++) totalGoals += champ1[i] + champ2[i];
        Console.WriteLine($"Общее количество мячей, забитых командой в двух чемпионатах: {totalGoals}");

        // M8.3
        Console.WriteLine("\n=== M8.3 ===");
        double[] area = new double[20];
        double[] harvest = new double[20];
        for (int i = 0; i < 20; i++)
        {
            area[i] = rnd.Next(50, 500);
            harvest[i] = area[i] * rnd.Next(15, 40);
        }
        PrintArray("Площади под пшеницей по районам (га)", area);
        PrintArray("Урожай по районам (ц)", harvest);

        Console.WriteLine("Способ 1 (без дополнительного массива):");
        double totalArea = 0, totalHarvest = 0;
        for (int i = 0; i < 20; i++)
        {
            double avgDistrict = harvest[i] / area[i];
            Console.WriteLine($"  Район {i + 1}: средняя урожайность = {avgDistrict:F2} ц/га");
            totalArea += area[i];
            totalHarvest += harvest[i];
        }
        double avgTotal = totalHarvest / totalArea;
        Console.WriteLine($"  Средняя урожайность по области: {avgTotal:F2} ц/га");

        Console.WriteLine("Способ 2 (с использованием дополнительного массива):");
        double[] avgDistricts = new double[20];
        for (int i = 0; i < 20; i++) avgDistricts[i] = harvest[i] / area[i];
        for (int i = 0; i < 20; i++) Console.WriteLine($"  Район {i + 1}: средняя урожайность = {avgDistricts[i]:F2} ц/га");
        double totalArea2 = 0, totalHarvest2 = 0;
        for (int i = 0; i < 20; i++) { totalArea2 += area[i]; totalHarvest2 += harvest[i]; }
        double avgTotal2 = totalHarvest2 / totalArea2;
        Console.WriteLine($"  Средняя урожайность по области: {avgTotal2:F2} ц/га");

        // M8.4
        Console.WriteLine("\n=== M8.4 ===");
        double[] area4 = new double[10];
        double[] yield4 = new double[10];
        for (int i = 0; i < 10; i++)
        {
            area4[i] = rnd.Next(50, 500);
            yield4[i] = rnd.Next(15, 40);
        }
        PrintArray("Площади под пшеницей по районам (га)", area4);
        PrintArray("Средняя урожайность по районам (ц/га)", yield4);

        Console.WriteLine("Способ 1 (без дополнительного массива):");
        double totalArea4 = 0, totalHarvest4 = 0;
        for (int i = 0; i < 10; i++)
        {
            totalArea4 += area4[i];
            totalHarvest4 += area4[i] * yield4[i];
        }
        double avgYieldOblast4 = totalHarvest4 / totalArea4;
        Console.WriteLine($"  Собрано пшеницы по области: {totalHarvest4:F2} ц");
        Console.WriteLine($"  Средняя урожайность по области: {avgYieldOblast4:F2} ц/га");

        Console.WriteLine("Способ 2 (с использованием дополнительного массива):");
        double[] harvest4 = new double[10];
        for (int i = 0; i < 10; i++) harvest4[i] = area4[i] * yield4[i];
        double totalHarvest4b = 0, totalArea4b = 0;
        for (int i = 0; i < 10; i++) { totalHarvest4b += harvest4[i]; totalArea4b += area4[i]; }
        double avgYieldOblast4b = totalHarvest4b / totalArea4b;
        Console.WriteLine($"  Собрано пшеницы по области: {totalHarvest4b:F2} ц");
        Console.WriteLine($"  Средняя урожайность по области: {avgYieldOblast4b:F2} ц/га");

        // M8.5
        Console.WriteLine("\n=== M8.5 ===");
        double[] length = new double[12], width = new double[12], height = new double[12];
        for (int i = 0; i < 12; i++)
        {
            length[i] = rnd.Next(1, 20);
            width[i] = rnd.Next(1, 20);
            height[i] = rnd.Next(1, 20);
        }
        PrintArray("Длины параллелепипедов", length);
        PrintArray("Ширины параллелепипедов", width);
        PrintArray("Высоты параллелепипедов", height);

        Console.WriteLine("Способ 1 (без дополнительного массива):");
        for (int i = 0; i < 12; i++) Console.WriteLine($"  Объём фигуры {i + 1}: {length[i] * width[i] * height[i]}");

        Console.WriteLine("Способ 2 (с использованием дополнительного массива):");
        double[] volume = new double[12];
        for (int i = 0; i < 12; i++) volume[i] = length[i] * width[i] * height[i];
        for (int i = 0; i < 12; i++) Console.WriteLine($"  Объём фигуры {i + 1}: {volume[i]}");
    }
}
