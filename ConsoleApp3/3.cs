double x, y;
x = double.Parse(Console.ReadLine());
y = double.Parse(Console.ReadLine());

if ((x >= -1 && x <= 1 && y <= x * x && y <= 1 && y <= 0) || ((x == 0) && (-1 <= y) && (y <= 0)))
    Console.WriteLine("входит");
else
    Console.WriteLine("не входит");