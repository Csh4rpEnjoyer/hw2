double x, y;
x = double.Parse(Console.ReadLine());
y = double.Parse(Console.ReadLine());
if (x <= 0)
{
    if (x * x + y * y <= 1)
        Console.WriteLine("входит");
    else
        Console.WriteLine("не входит");
}
else
{
    if (x <= 1 && y <= 1)
        Console.WriteLine("входит");
    else
        Console.WriteLine("не входит");
}