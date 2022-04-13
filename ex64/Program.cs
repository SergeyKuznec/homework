Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число M");
int n = int.Parse(Console.ReadLine());
void nat(int a, int b)
{
    if (a > b)
    {
        Console.Write($"{b} ");
        nat(a, b + 1);
    }
    if (a < b)
    {
        Console.Write($"{b} ");
        nat(a, b - 1);
    }
    if (a == b)
    {
        Console.Write($"{b} ");
    }
}
nat(m, n);