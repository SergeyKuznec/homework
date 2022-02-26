Console.WriteLine("Введите 3 числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c) 
{
    Console.WriteLine($"max = {a}");
}
if (b > a && b > c) 
{
    Console.WriteLine($"max = {b}");
}
if (c > a && c > b) 
{
    Console.WriteLine($"max = {c}");
}

