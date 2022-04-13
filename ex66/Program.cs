Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число M");
int n = int.Parse(Console.ReadLine());
int sum(int a, int b)
{
    
    if (a > b)
    {
       return b + sum(a, b + 1);
    }
    if (a < b)
    {
       return a + sum(a + 1, b);
    }
    else return a;
}
Console.WriteLine($"Сумма цифр равна {sum(m, n)}");