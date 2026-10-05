using System;

class Point3D
{
    public double X;
    public double Y;
    public double Z;

    public Point3D()
    {
        X = 0;
        Y = 0;
        Z = 0;
    }

    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public void MoveBy(double dx, double dy, double dz)
    {
        X += dx;
        Y += dy;
        Z += dz;
    }

    public string Info()
    {
        return $"X = {X}, Y = {Y}, Z = {Z}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты первой точки (X Y Z через пробел):");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');

        double x1 = double.Parse(parts[0]);
        double y1 = double.Parse(parts[1]);
        double z1 = double.Parse(parts[2]);

        Point3D point1 = new Point3D(x1, y1, z1);
        Point3D point2 = new Point3D(1, 2, 3);

        Console.WriteLine("Точка 1 до перемещения: " + point1.Info());
        Console.WriteLine("Точка 2 до перемещения: " + point2.Info());

        point1.MoveBy(1, 1, 1);
        point2.MoveBy(5, -2, 3);

        Console.WriteLine("Точка 1 после перемещения: " + point1.Info());
        Console.WriteLine("Точка 2 после перемещения: " + point2.Info());


    }
}
