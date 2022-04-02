// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("задайте количество строк"); 
int numRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("задайте количество столбцов"); 
int numColumn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(); 
double [,] mass = new double[numRow, numColumn];
double [,] randArr(int row, int col)
{
    double [,] arr = new double[row, col];
    for (int i = 0;  i < row; i++)
{
    for (int j = 0; j < col; j++)
    {

        arr[i, j] = new Random().Next(-100, 100) + new Random().NextDouble();
    }
}
return arr;
}

void printarr(double [,] arra, int row, int col)
{
   for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
       Console.Write($"{mass[i, j]:0.00}\t"); 
    }
    Console.WriteLine(); 
} 
}

mass = randArr(numRow, numColumn);
printarr(mass, numRow, numColumn);
