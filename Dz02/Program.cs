Console.Clear();

Console.WriteLine("Данны уравнения: y = k1*x + b1 и y = k2*x + b2");

Console.Write("Введите переменную b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите переменную k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите переменную b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите переменную k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
{
 Console.WriteLine("Не имеют точек пересечения");
}
else
{
    double x =Math.Round(((b2-b1) / (k1-k2)),2);
    double y = Math.Round((k1*x + b1), 2);
    Console.WriteLine($"Координаты точки пересечения: ({x};{y})");
}

