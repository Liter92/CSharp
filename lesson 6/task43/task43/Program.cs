Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x, y;

x = -(b1 - b2) / (k1 - k2);
y = k1 * x + b1;

x = Math.Round(x, 2);
y = Math.Round(y, 2);

Console.WriteLine($"точка пересечения: ({x};{y})");