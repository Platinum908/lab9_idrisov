//Лаб 9 Высокий 22
try
{
    Console.WriteLine("Введите длины сторон параллелипипеда:");
    Console.Write("a: ");
    double a = double.Parse(Console.ReadLine()!);
    Console.Write("b: ");
    double b = double.Parse(Console.ReadLine()!);
    Console.Write("c: ");
    double c = double.Parse(Console.ReadLine()!);
    Numbers num = new Numbers(a, b, c);
    Console.Write("Площадь поверхности параллелипипеда: ");
    num.Area();
    Console.Write($"Сумма длин сторон всех ребер параллелепипеда: ");
    num.SumLength();
    Console.Write("Информация о параллепипеде: ");
    num.Print();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
class Numbers
{
    private double a;
    private double b;
    private double c;

    public Numbers(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public double A
    {
        get { return a; }
        set { a = value; }
    }
    public double B
    {
        get { return b; }
        set { b = value; }
    }
    public double C
    {
        get { return c; }
        set { c = value; }
    }
    public void Area()
    {
        Console.WriteLine(2*(a*b+a*c+b*c));
    }
    public void SumLength()
    {
        Console.WriteLine(4*(a + b + c));
    }
    public void Print()
    {
        Console.WriteLine($"a: {a}, b: {b}, c: {c}");
    }
}
