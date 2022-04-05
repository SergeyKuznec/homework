// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("задайте количество строк"); 
int numRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("задайте количество столбцов"); 
int numColumn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(); 
int [,] mass = new int[numRow, numColumn];
int [,] randArr(int row, int col)
{
    int [,] arr = new int[row, col];
    for (int i = 0;  i < row; i++)
{
    for (int j = 0; j < col; j++)
    {

        arr[i, j] = new Random().Next(-100, 100);
    }
}
return arr;
}

void printarr(int [,] arra)
{
   for (int i = 0; i < arra.GetLength(0); i++)
{
    for (int j = 0; j < arra.GetLength(1); j++)
    {
       Console.Write($"{mass[i, j]}\t"); 
    }
    Console.WriteLine(); 
} 
}
void average(int [,] ar)
{
    for (int i = 0; i < ar.GetLength(1); i++)
{
    double sum = 0;
    for (int j = 0; j < ar.GetLength(0); j++)
    {
       
       sum = sum + ar[j,i]; 
       if (j == ar.GetLength(0) - 1)
       {
        double arrr = sum/ar.GetLength(0);
        Console.WriteLine($"среднее арифметическое {i} столбца равно {arrr:0.00}");
       }
       
    }
}
}
mass = randArr(numRow, numColumn);
printarr(mass);
average(mass);

