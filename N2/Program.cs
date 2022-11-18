Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x;
double y;

if (k1 != k2)
{
    x = (b2 - b1) / (k1 - k2);
    y = (k1 * x) + b1;
    Console.Write($"Точка пересечения: ({x},{y})");
}
else if (b1 == b2) Console.Write("Прямые совпадают.");
else Console.Write("Прямые параллельны.");