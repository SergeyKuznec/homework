Console.WriteLine("Введите координату Х первой точки");
int X1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y первой точки");
int Y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z первой точки");
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Х второй точки");
int X2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y второй точки");
int Y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Z второй точки");
int Z2 = Convert.ToInt32(Console.ReadLine());

double dis = Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1) + (Z2 - Z1) * (Z2 - Z1));
Console.WriteLine($"расстояние между точками равно : {dis:f3}");
