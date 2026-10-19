using System;

//1
class A1
{
    public char c;
    public A1(char c) { this.c = c; }
    public A1(A1 o) { c = o.c; }
}

class B1 : A1
{
    public string s;
    public B1(char c, string s) : base(c) { this.s = s; }
    public B1(B1 o) : base(o) { s = o.s; }
}

class C1 : B1
{
    public int n;
    public C1(char c, string s, int n) : base(c, s) { this.n = n; }
    public C1(C1 o) : base(o) { n = o.n; }
}

//2
class A2
{
    public int x;
    public A2(int x) { this.x = x; }
    public virtual int this[int i]
    {
        get
        {
            int k = Math.Abs(x);
            for (int j = 0; j < i; j++) k /= 10;
            return k % 10;
        }
    }
}

class B2 : A2
{
    public int y;
    public B2(int x, int y) : base(x) { this.y = y; }
    public int this[int f, int i]
    {
        get
        {
            int k = Math.Abs(f == 1 ? x : y);
            for (int j = 0; j < i; j++) k /= 10;
            return k % 10;
        }
    }
    public override int this[int i]
    {
        get
        {
            int k = Math.Abs(x + y);
            for (int j = 0; j < i; j++) k /= 10;
            return k % 10;
        }
    }
}

//3
class A3
{
    protected int[] a;
    public A3(int n) { a = new int[n]; }
    public int this[int i]
    {
        get { return a[i]; }
        set { a[i] = value; }
    }
    public int Size
    {
        get { return a.Length; }
    }
}

class B3 : A3
{
    protected char[] b;
    public B3(int n, int m) : base(n) { b = new char[m]; }
    public char this[char i]
    {
        get { return b[i - 'a']; }
        set { b[i - 'a'] = value; }
    }
    public new int[] Size
    {
        get { return new int[] { a.Length, b.Length }; }
    }
}

class Program
{
    static void Main()
    {
        //1
        C1 c1 = new C1('a', "text", 5);
        C1 c2 = new C1(c1);
        Console.WriteLine(c2.c + " " + c2.s + " " + c2.n);

        //2
        B2 d1 = new B2(123, 456);
        Console.WriteLine(d1[0] + " " + d1[1] + " " + d1[2]);
        Console.WriteLine(d1[1, 0] + " " + d1[2, 2]);

        //3
        B3 e1 = new B3(3, 3);
        e1[0] = 10;
        e1['a'] = 'z';
        Console.WriteLine(e1[0] + " " + e1['a']);
        int[] sz = e1.Size;
        Console.WriteLine(sz[0] + " " + sz[1]);
    }
}
