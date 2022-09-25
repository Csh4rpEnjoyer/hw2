double x, y;
x = double.Parse(Console.ReadLine());
y = double.Parse(Console.ReadLine());
if (Math.Abs(x + y) == 1)
    Console.WriteLine("входит");
else
    Console.WriteLine("не входит");
