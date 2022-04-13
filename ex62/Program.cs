// Задача 62: Заполните спирально массив 4 на 4(массив заполняется по часовой стрелке от периферии к центру).
Console.WriteLine("Введите длину стороны квадратной матрицы");
int a = Convert.ToInt32(Console.ReadLine());

int [,] mass = new int [a, a];
int num = 1;
int i = 0;
int j = 0;
while (num <= a*a)
{
     mass[i, j] = num;
     if (i <= j+1 && i + j < a - 1)
        ++j;
    else if (i < j && i + j >= a-1)
        ++i;
    else if (i >= j && i + j > a-1)
        --j;
    else
        --i;
    num ++;
}
for (i = 0; i < mass.GetLength(0); i++)
{
    for (j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write($"{mass[i, j]}  ");
    }
    Console.WriteLine();
}