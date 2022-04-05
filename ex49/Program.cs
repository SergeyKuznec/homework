//задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные,
// и замените эти элементы на их квадраты.

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

void printarr(int [,] arra, int row, int col)
{
   for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
       Console.Write($"{mass[i, j]}\t"); 
    }
    Console.WriteLine(); 
} 
}
int [,] square(int [,] ar, int r, int c)
{
    for (int i = 0; i < r; i++)
{
    for (int j = 0; j < c; j++)
    {
       if (i % 2 ==0 & j % 2 == 0) ar[i,j] = ar[i,j]*ar[i,j];
    }
}
return ar;
}
mass = randArr(numRow, numColumn);
printarr(mass, numRow, numColumn);
square(mass, numRow, numColumn);
Console.WriteLine();
printarr(mass, numRow, numColumn);
