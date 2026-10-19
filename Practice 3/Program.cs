using System;
using System.Text;

//1
class Point
{
    int x, y;

    public Point() { x = 0; y = 0; }
    public Point(int x, int y) { this.x = x; this.y = y; }

    public void Show() { Console.WriteLine("Точка: (" + x + ", " + y + ")"); }
    public double Distance() { return Math.Sqrt(x * x + y * y); }
    public void Move(int a, int b) { x += a; y += b; }

    public int X { get { return x; } set { x = value; } }
    public int Y { get { return y; } set { y = value; } }
    public int Scalar { set { x *= value; y *= value; } }

    public int this[int i]
    {
        get
        {
            if (i == 0) return x;
            if (i == 1) return y;
            Console.WriteLine("Ошибка: неверный индекс");
            return 0;
        }
        set
        {
            if (i == 0) x = value;
            else if (i == 1) y = value;
            else Console.WriteLine("Ошибка: неверный индекс");
        }
    }

    public static Point operator ++(Point p) { return new Point(p.x + 1, p.y + 1); }
    public static Point operator --(Point p) { return new Point(p.x - 1, p.y - 1); }
    public static bool operator true(Point p) { return p.x == p.y; }
    public static bool operator false(Point p) { return p.x != p.y; }
    public static Point operator +(Point p, int s) { return new Point(p.x + s, p.y + s); }
}

//2
class Triangle
{
    int a, b, c;

    public Triangle(int a, int b, int c) { this.a = a; this.b = b; this.c = c; }

    public void Show() { Console.WriteLine("Стороны: " + a + ", " + b + ", " + c); }
    public int Perimeter() { return a + b + c; }
    public double Area()
    {
        double p = Perimeter() / 2.0;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    public int A { get { return a; } set { a = value; } }
    public int B { get { return b; } set { b = value; } }
    public int C { get { return c; } set { c = value; } }
    public bool Exists { get { return a + b > c && a + c > b && b + c > a; } }

    public int this[int i]
    {
        get
        {
            if (i == 0) return a;
            if (i == 1) return b;
            if (i == 2) return c;
            Console.WriteLine("Ошибка: неверный индекс");
            return 0;
        }
        set
        {
            if (i == 0) a = value;
            else if (i == 1) b = value;
            else if (i == 2) c = value;
            else Console.WriteLine("Ошибка: неверный индекс");
        }
    }

    public static Triangle operator ++(Triangle t) { return new Triangle(t.a + 1, t.b + 1, t.c + 1); }
    public static Triangle operator --(Triangle t) { return new Triangle(t.a - 1, t.b - 1, t.c - 1); }
    public static bool operator true(Triangle t) { return t.Exists; }
    public static bool operator false(Triangle t) { return !t.Exists; }
    public static Triangle operator *(Triangle t, int s) { return new Triangle(t.a * s, t.b * s, t.c * s); }
}

//3
class Rectangle
{
    int a, b;

    public Rectangle(int a, int b) { this.a = a; this.b = b; }

    public void Show() { Console.WriteLine("Стороны: " + a + ", " + b); }
    public int Perimeter() { return 2 * (a + b); }
    public int Area() { return a * b; }

    public int A { get { return a; } set { a = value; } }
    public int B { get { return b; } set { b = value; } }
    public bool IsSquare { get { return a == b; } }

    public int this[int i]
    {
        get
        {
            if (i == 0) return a;
            if (i == 1) return b;
            Console.WriteLine("Ошибка: неверный индекс");
            return 0;
        }
        set
        {
            if (i == 0) a = value;
            else if (i == 1) b = value;
            else Console.WriteLine("Ошибка: неверный индекс");
        }
    }

    public static Rectangle operator ++(Rectangle r) { return new Rectangle(r.a + 1, r.b + 1); }
    public static Rectangle operator --(Rectangle r) { return new Rectangle(r.a - 1, r.b - 1); }
    public static bool operator true(Rectangle r) { return r.IsSquare; }
    public static bool operator false(Rectangle r) { return !r.IsSquare; }
    public static Rectangle operator *(Rectangle r, int s) { return new Rectangle(r.a * s, r.b * s); }
}

//4
class Money
{
    int first, second;

    public Money(int first, int second) { this.first = first; this.second = second; }

    public void Show() { Console.WriteLine("Номинал: " + first + ", количество: " + second); }
    public bool Enough(int n) { return Sum >= n; }
    public int HowMany(int n) { return Sum / n; }

    public int First { get { return first; } set { first = value; } }
    public int Second { get { return second; } set { second = value; } }
    public int Sum { get { return first * second; } }

    public int this[int i]
    {
        get
        {
            if (i == 0) return first;
            if (i == 1) return second;
            Console.WriteLine("Ошибка: неверный индекс");
            return 0;
        }
        set
        {
            if (i == 0) first = value;
            else if (i == 1) second = value;
            else Console.WriteLine("Ошибка: неверный индекс");
        }
    }

    public static Money operator ++(Money m) { return new Money(m.first + 1, m.second + 1); }
    public static Money operator --(Money m) { return new Money(m.first - 1, m.second - 1); }
    public static bool operator !(Money m) { return m.second != 0; }
    public static Money operator +(Money m, int s) { return new Money(m.first, m.second + s); }
}

//5
class MyIntArray
{
    int[] IntArray;

    public MyIntArray(int n) { IntArray = new int[n]; }

    public void Input()
    {
        for (int i = 0; i < IntArray.Length; i++)
        {
            Console.Write("Элемент " + i + ": ");
            IntArray[i] = int.Parse(Console.ReadLine());
        }
    }
    public void Show()
    {
        foreach (int e in IntArray) Console.Write(e + " ");
        Console.WriteLine();
    }
    public void Sort() { Array.Sort(IntArray); }

    public int Size { get { return IntArray.Length; } }
    public int Multiply
    {
        set { for (int i = 0; i < IntArray.Length; i++) IntArray[i] *= value; }
    }

    public int this[int i]
    {
        get { return IntArray[i]; }
        set { IntArray[i] = value; }
    }

    public static MyIntArray operator ++(MyIntArray m)
    {
        MyIntArray r = new MyIntArray(m.Size);
        for (int i = 0; i < m.Size; i++) r[i] = m[i] + 1;
        return r;
    }
    public static MyIntArray operator --(MyIntArray m)
    {
        MyIntArray r = new MyIntArray(m.Size);
        for (int i = 0; i < m.Size; i++) r[i] = m[i] - 1;
        return r;
    }
    public static bool operator !(MyIntArray m)
    {
        for (int i = 0; i < m.Size - 1; i++)
            if (m[i] > m[i + 1]) return true;
        return false;
    }
    public static MyIntArray operator *(MyIntArray m, int s)
    {
        MyIntArray r = new MyIntArray(m.Size);
        for (int i = 0; i < m.Size; i++) r[i] = m[i] * s;
        return r;
    }
    public static implicit operator int[](MyIntArray m) { return m.IntArray; }
    public static implicit operator MyIntArray(int[] arr)
    {
        MyIntArray r = new MyIntArray(arr.Length);
        for (int i = 0; i < arr.Length; i++) r[i] = arr[i];
        return r;
    }
}

//6
class TwoArray
{
    int[,] intArray;

    public TwoArray(int n, int m) { intArray = new int[n, m]; }

    public int Rows { get { return intArray.GetLength(0); } }
    public int Cols { get { return intArray.GetLength(1); } }

    public void Input()
    {
        for (int i = 0; i < Rows; i++)
            for (int j = 0; j < Cols; j++)
            {
                Console.Write("Элемент [" + i + "," + j + "]: ");
                intArray[i, j] = int.Parse(Console.ReadLine());
            }
    }
    public void Show()
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++) Console.Write(intArray[i, j] + " ");
            Console.WriteLine();
        }
    }
    public int ColumnSum(int j)
    {
        int s = 0;
        for (int i = 0; i < Rows; i++) s += intArray[i, j];
        return s;
    }

    public int Zeros
    {
        get
        {
            int k = 0;
            foreach (int e in intArray) if (e == 0) k++;
            return k;
        }
    }
    public int Diagonal
    {
        set
        {
            for (int i = 0; i < Rows && i < Cols; i++) intArray[i, i] = value;
        }
    }

    public int this[int i, int j]
    {
        get { return intArray[i, j]; }
        set { intArray[i, j] = value; }
    }

    public static TwoArray operator ++(TwoArray t)
    {
        TwoArray r = new TwoArray(t.Rows, t.Cols);
        for (int i = 0; i < t.Rows; i++)
            for (int j = 0; j < t.Cols; j++) r[i, j] = t[i, j] + 1;
        return r;
    }
    public static TwoArray operator --(TwoArray t)
    {
        TwoArray r = new TwoArray(t.Rows, t.Cols);
        for (int i = 0; i < t.Rows; i++)
            for (int j = 0; j < t.Cols; j++) r[i, j] = t[i, j] - 1;
        return r;
    }
    public static bool operator true(TwoArray t) { return t.Rows == t.Cols; }
    public static bool operator false(TwoArray t) { return t.Rows != t.Cols; }
    public static TwoArray operator +(TwoArray a, TwoArray b)
    {
        TwoArray r = new TwoArray(a.Rows, a.Cols);
        for (int i = 0; i < a.Rows; i++)
            for (int j = 0; j < a.Cols; j++) r[i, j] = a[i, j] + b[i, j];
        return r;
    }
    public static implicit operator int[,](TwoArray t) { return t.intArray; }
    public static implicit operator TwoArray(int[,] arr)
    {
        TwoArray r = new TwoArray(arr.GetLength(0), arr.GetLength(1));
        for (int i = 0; i < r.Rows; i++)
            for (int j = 0; j < r.Cols; j++) r[i, j] = arr[i, j];
        return r;
    }
}

//7
class DoubelArray
{
    double[][] doubelArray;

    public DoubelArray(int[] sizes)
    {
        doubelArray = new double[sizes.Length][];
        for (int i = 0; i < sizes.Length; i++) doubelArray[i] = new double[sizes[i]];
    }

    public int Rows { get { return doubelArray.Length; } }

    public void Input()
    {
        for (int i = 0; i < doubelArray.Length; i++)
            for (int j = 0; j < doubelArray[i].Length; j++)
            {
                Console.Write("Элемент [" + i + "][" + j + "]: ");
                doubelArray[i][j] = double.Parse(Console.ReadLine());
            }
    }
    public void Show()
    {
        for (int i = 0; i < doubelArray.Length; i++)
        {
            foreach (double e in doubelArray[i]) Console.Write(e + " ");
            Console.WriteLine();
        }
    }
    public void SortDesc()
    {
        for (int i = 0; i < doubelArray.Length; i++)
        {
            Array.Sort(doubelArray[i]);
            Array.Reverse(doubelArray[i]);
        }
    }

    public int Count
    {
        get
        {
            int k = 0;
            for (int i = 0; i < doubelArray.Length; i++) k += doubelArray[i].Length;
            return k;
        }
    }
    public double Add
    {
        set
        {
            for (int i = 0; i < doubelArray.Length; i++)
                for (int j = 0; j < doubelArray[i].Length; j++) doubelArray[i][j] += value;
        }
    }

    public double this[int i, int j]
    {
        get { return doubelArray[i][j]; }
        set { doubelArray[i][j] = value; }
    }

    public static DoubelArray operator ++(DoubelArray d)
    {
        DoubelArray r = new DoubelArray(d.Sizes());
        for (int i = 0; i < d.Rows; i++)
            for (int j = 0; j < d.doubelArray[i].Length; j++) r[i, j] = d[i, j] + 1;
        return r;
    }
    public static DoubelArray operator --(DoubelArray d)
    {
        DoubelArray r = new DoubelArray(d.Sizes());
        for (int i = 0; i < d.Rows; i++)
            for (int j = 0; j < d.doubelArray[i].Length; j++) r[i, j] = d[i, j] - 1;
        return r;
    }
    public static bool operator true(DoubelArray d)
    {
        for (int i = 0; i < d.Rows; i++)
            for (int j = 0; j < d.doubelArray[i].Length - 1; j++)
                if (d[i, j] > d[i, j + 1]) return false;
        return true;
    }
    public static bool operator false(DoubelArray d)
    {
        for (int i = 0; i < d.Rows; i++)
            for (int j = 0; j < d.doubelArray[i].Length - 1; j++)
                if (d[i, j] > d[i, j + 1]) return true;
        return false;
    }
    public static implicit operator double[][](DoubelArray d) { return d.doubelArray; }
    public static implicit operator DoubelArray(double[][] arr)
    {
        int[] sizes = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++) sizes[i] = arr[i].Length;
        DoubelArray r = new DoubelArray(sizes);
        for (int i = 0; i < arr.Length; i++)
            for (int j = 0; j < arr[i].Length; j++) r[i, j] = arr[i][j];
        return r;
    }

    int[] Sizes()
    {
        int[] s = new int[doubelArray.Length];
        for (int i = 0; i < s.Length; i++) s[i] = doubelArray[i].Length;
        return s;
    }
}

//8
class MyString
{
    string line;

    public MyString(string s) { line = s; }

    public int DigitCount()
    {
        int k = 0;
        foreach (char c in line) if (char.IsDigit(c)) k++;
        return k;
    }
    public void ShowSingle()
    {
        foreach (char c in line)
        {
            int k = 0;
            foreach (char d in line) if (c == d) k++;
            if (k == 1) Console.Write(c + " ");
        }
        Console.WriteLine();
    }
    public void ShowLongestRepeat()
    {
        if (line.Length == 0) return;
        int best = 1, cur = 1, pos = 0;
        for (int i = 1; i < line.Length; i++)
        {
            if (line[i] == line[i - 1]) cur++;
            else cur = 1;
            if (cur > best) { best = cur; pos = i; }
        }
        Console.WriteLine(line.Substring(pos - best + 1, best));
    }

    public int Length { get { return line.Length; } }

    public char this[int i] { get { return line[i]; } }

    public static bool operator !(MyString s) { return s.line.Length != 0; }
    public static bool operator true(MyString s)
    {
        for (int i = 0; i < s.line.Length / 2; i++)
            if (s.line[i] != s.line[s.line.Length - 1 - i]) return false;
        return true;
    }
    public static bool operator false(MyString s)
    {
        for (int i = 0; i < s.line.Length / 2; i++)
            if (s.line[i] != s.line[s.line.Length - 1 - i]) return true;
        return false;
    }
    public static bool operator &(MyString a, MyString b)
    {
        return a.line.ToLower() == b.line.ToLower();
    }
    public static implicit operator string(MyString s) { return s.line; }
    public static implicit operator MyString(string s) { return new MyString(s); }
}

//9
class MyStringBuilder
{
    StringBuilder line;

    public MyStringBuilder() { line = new StringBuilder(); }
    public MyStringBuilder(string s) { line = new StringBuilder(s); }

    public int SpaceCount()
    {
        int k = 0;
        for (int i = 0; i < line.Length; i++) if (line[i] == ' ') k++;
        return k;
    }
    public void ToLowerAll()
    {
        for (int i = 0; i < line.Length; i++) line[i] = char.ToLower(line[i]);
    }
    public void RemovePunctuation()
    {
        for (int i = line.Length - 1; i >= 0; i--)
            if (char.IsPunctuation(line[i])) line.Remove(i, 1);
    }

    public int Length { get { return line.Length; } }
    public string Text
    {
        get { return line.ToString(); }
        set { line = new StringBuilder(value); }
    }

    public char this[int i]
    {
        get { return line[i]; }
        set { line[i] = value; }
    }

    public static MyStringBuilder operator +(MyStringBuilder m)
    {
        return new MyStringBuilder(m.line.ToString().ToLower());
    }
    public static MyStringBuilder operator -(MyStringBuilder m)
    {
        return new MyStringBuilder(m.line.ToString().ToUpper());
    }
    public static bool operator true(MyStringBuilder m) { return m.line.Length != 0; }
    public static bool operator false(MyStringBuilder m) { return m.line.Length == 0; }
    public static bool operator &(MyStringBuilder a, MyStringBuilder b)
    {
        return a.line.ToString().ToLower() == b.line.ToString().ToLower();
    }
    public static implicit operator StringBuilder(MyStringBuilder m) { return m.line; }
    public static implicit operator MyStringBuilder(StringBuilder s) { return new MyStringBuilder(s.ToString()); }
}

//10
class Date
{
    DateTime data;

    public Date() { data = new DateTime(2000, 1, 1); }
    public Date(DateTime d) { data = d; }

    public DateTime Previous() { return data.AddDays(-1); }
    public DateTime Next() { return data.AddDays(1); }
    public int DaysToEndOfMonth()
    {
        return DateTime.DaysInMonth(data.Year, data.Month) - data.Day;
    }

    public DateTime Data { get { return data; } set { data = value; } }
    public bool IsLeap { get { return DateTime.IsLeapYear(data.Year); } }

    public DateTime this[int i] { get { return data.AddDays(i); } }

    public static bool operator !(Date d)
    {
        return d.data.Day != DateTime.DaysInMonth(d.data.Year, d.data.Month);
    }
    public static bool operator true(Date d) { return d.data.Month == 1 && d.data.Day == 1; }
    public static bool operator false(Date d) { return !(d.data.Month == 1 && d.data.Day == 1); }
    public static bool operator &(Date a, Date b) { return a.data == b.data; }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        //1
        Point p1 = new Point(3, 4);
        p1.Show();
        Console.WriteLine("Расстояние: " + p1.Distance());
        p1.Move(1, 2);
        p1.Show();
        p1.Scalar = 2;
        p1.Show();
        Console.WriteLine("x = " + p1[0] + ", y = " + p1[1]);
        Console.WriteLine(p1[5]);
        p1++;
        p1.Show();
        p1--;
        p1.Show();
        p1 = p1 + 5;
        p1.Show();
        Point p2 = new Point(7, 7);
        if (p2) Console.WriteLine("x и y совпадают");
        else Console.WriteLine("x и y не совпадают");

        //2
        Triangle t1 = new Triangle(3, 4, 5);
        t1.Show();
        Console.WriteLine("Периметр: " + t1.Perimeter());
        Console.WriteLine("Площадь: " + t1.Area());
        Console.WriteLine("Существует: " + t1.Exists);
        Console.WriteLine("a = " + t1[0] + ", b = " + t1[1] + ", c = " + t1[2]);
        Console.WriteLine(t1[7]);
        t1++;
        t1.Show();
        t1--;
        t1.Show();
        t1 = t1 * 2;
        t1.Show();
        if (t1) Console.WriteLine("Треугольник существует");
        else Console.WriteLine("Треугольник не существует");

        //3
        Rectangle r1 = new Rectangle(3, 5);
        r1.Show();
        Console.WriteLine("Периметр: " + r1.Perimeter());
        Console.WriteLine("Площадь: " + r1.Area());
        Console.WriteLine("Квадрат: " + r1.IsSquare);
        Console.WriteLine("a = " + r1[0] + ", b = " + r1[1]);
        Console.WriteLine(r1[3]);
        r1++;
        r1.Show();
        r1--;
        r1.Show();
        r1 = r1 * 2;
        r1.Show();
        Rectangle r2 = new Rectangle(4, 4);
        if (r2) Console.WriteLine("Это квадрат");
        else Console.WriteLine("Это не квадрат");

        //4
        Money m1 = new Money(100, 5);
        m1.Show();
        Console.WriteLine("Сумма: " + m1.Sum);
        Console.WriteLine("Хватит на 300 руб: " + m1.Enough(300));
        Console.WriteLine("Товаров по 70 руб: " + m1.HowMany(70));
        Console.WriteLine("first = " + m1[0] + ", second = " + m1[1]);
        Console.WriteLine(m1[4]);
        m1++;
        m1.Show();
        m1--;
        m1.Show();
        Console.WriteLine("Купюры есть: " + !m1);
        m1 = m1 + 3;
        m1.Show();

        //5
        MyIntArray a1 = new MyIntArray(5);
        a1.Input();
        a1.Show();
        Console.WriteLine("Размер: " + a1.Size);
        Console.WriteLine("Не упорядочен: " + !a1);
        a1.Sort();
        a1.Show();
        Console.WriteLine("Не упорядочен: " + !a1);
        a1++;
        a1.Show();
        a1--;
        a1.Show();
        a1 = a1 * 3;
        a1.Show();
        a1.Multiply = 2;
        a1.Show();
        int[] simple = a1;
        Console.WriteLine("Первый элемент обычного массива: " + simple[0]);
        MyIntArray a2 = new int[] { 1, 2, 3 };
        a2.Show();

        //6
        TwoArray b1 = new TwoArray(2, 2);
        b1.Input();
        b1.Show();
        Console.WriteLine("Сумма 0-го столбца: " + b1.ColumnSum(0));
        Console.WriteLine("Нулей: " + b1.Zeros);
        b1.Diagonal = 9;
        b1.Show();
        Console.WriteLine("Элемент [0,1]: " + b1[0, 1]);
        b1++;
        b1.Show();
        b1--;
        b1.Show();
        if (b1) Console.WriteLine("Массив квадратный");
        else Console.WriteLine("Массив не квадратный");
        TwoArray b2 = b1 + b1;
        b2.Show();
        int[,] simple2 = b2;
        Console.WriteLine("Элемент обычного массива: " + simple2[0, 0]);
        TwoArray b3 = new int[,] { { 1, 2 }, { 3, 4 } };
        b3.Show();

        //7
        DoubelArray d1 = new DoubelArray(new int[] { 2, 3 });
        d1.Input();
        d1.Show();
        Console.WriteLine("Элементов: " + d1.Count);
        if (d1) Console.WriteLine("Все строки по возрастанию");
        else Console.WriteLine("Не все строки по возрастанию");
        d1.SortDesc();
        d1.Show();
        d1.Add = 1.5;
        d1.Show();
        Console.WriteLine("Элемент [0,1]: " + d1[0, 1]);
        d1++;
        d1.Show();
        d1--;
        d1.Show();
        double[][] simple3 = d1;
        Console.WriteLine("Первый элемент обычного массива: " + simple3[0][0]);
        DoubelArray d2 = new double[][] { new double[] { 1, 2 }, new double[] { 3 } };
        d2.Show();

        //8
        MyString s1 = new MyString("aabbb12331");
        Console.WriteLine("Цифр: " + s1.DigitCount());
        s1.ShowSingle();
        s1.ShowLongestRepeat();
        Console.WriteLine("Длина: " + s1.Length);
        Console.WriteLine("Символ 2: " + s1[2]);
        Console.WriteLine("Не пустая: " + !s1);
        MyString s2 = new MyString("abcba");
        if (s2) Console.WriteLine("Палиндром");
        else Console.WriteLine("Не палиндром");
        MyString s3 = new MyString("ABCBA");
        Console.WriteLine("Равны без учета регистра: " + (s2 & s3));
        string str = s2;
        Console.WriteLine(str);
        MyString s4 = "привет";
        Console.WriteLine(s4.Length);

        //9
        MyStringBuilder sb1 = new MyStringBuilder("Hello, World! Привет, Мир.");
        Console.WriteLine("Пробелов: " + sb1.SpaceCount());
        sb1.ToLowerAll();
        Console.WriteLine(sb1.Text);
        sb1.RemovePunctuation();
        Console.WriteLine(sb1.Text);
        Console.WriteLine("Длина: " + sb1.Length);
        Console.Write("Введите строку: ");
        sb1.Text = Console.ReadLine();
        Console.WriteLine(sb1.Text);
        Console.WriteLine("Символ 0: " + sb1[0]);
        MyStringBuilder sb2 = -sb1;
        Console.WriteLine(sb2.Text);
        MyStringBuilder sb3 = +sb2;
        Console.WriteLine(sb3.Text);
        if (sb1) Console.WriteLine("Строка не пустая");
        else Console.WriteLine("Строка пустая");
        MyStringBuilder sb4 = new MyStringBuilder();
        if (sb4) Console.WriteLine("Строка не пустая");
        else Console.WriteLine("Строка пустая");
        Console.WriteLine("Равны без учета регистра: " + (sb2 & sb3));
        StringBuilder simpleSb = sb1;
        Console.WriteLine(simpleSb);
        MyStringBuilder sb5 = new StringBuilder("abc");
        Console.WriteLine(sb5.Text);

        //10
        Date dt1 = new Date(new DateTime(2024, 2, 28));
        Date dt2 = new Date();
        Console.WriteLine("Дата: " + dt1.Data.ToShortDateString());
        Console.WriteLine("Предыдущий день: " + dt1.Previous().ToShortDateString());
        Console.WriteLine("Следующий день: " + dt1.Next().ToShortDateString());
        Console.WriteLine("Дней до конца месяца: " + dt1.DaysToEndOfMonth());
        Console.WriteLine("Високосный: " + dt1.IsLeap);
        Console.WriteLine("Через 5 дней: " + dt1[5].ToShortDateString());
        Console.WriteLine("5 дней назад: " + dt1[-5].ToShortDateString());
        Console.WriteLine("Не последний день месяца: " + !dt1);
        if (dt2) Console.WriteLine("Начало года");
        else Console.WriteLine("Не начало года");
        Console.WriteLine("Даты равны: " + (dt1 & dt2));
        dt1.Data = new DateTime(2023, 12, 31);
        Console.WriteLine("Дата: " + dt1.Data.ToShortDateString());

        Console.ReadKey();
    }
}
