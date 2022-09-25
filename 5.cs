double a, b, c, m;
Console.WriteLine("Введите три числа");
a = double.Parse(Console.ReadLine());
b = double.Parse(Console.ReadLine());
c = double.Parse(Console.ReadLine());
if (b < a)
{
    m = a;
    a = b;
    b = m;
}
if (c < a)
{
    m = a;
    a = c;
    c = m;
}
if (c < b)
{
    m = b;
    b = c;
    c = m;
}
Console.WriteLine($"Полученный ряд чисел в порядке возрастания={a} {b} {c};");

