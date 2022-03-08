Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < N + 1; i++)
{
    Console.Write($"{i * i * i}, ");
}