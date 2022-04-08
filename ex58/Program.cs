//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void randarr(int[,] array)
{
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             array[i,j] = new Random().Next(-10, 10);
         }
     }
}
void printarr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             Console.Write($"{array[i,j]}\t");
         }
         Console.WriteLine();
     }
}
int[,] prod(int[,] array1, int[,] array2)
{
    if (array1.GetLength(0) != array2.GetLength(1))
    {
        Console.WriteLine("перемножение невозможно");
    } 
    int [,] prodarray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
      for (int j = 0; j < array2.GetLength(1); j++)
      {
          for (int k = 0; k < array1.GetLength(1); k++)
          {
              prodarray[i,j] = prodarray[i,j] + array1[i,k] * array2[k,j];
          }
      }
    } 
    return prodarray;     
}

Console.Write("Задайте количество строк в первом массиве: ");
int m1 = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов в первом массиве: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Задайте количество строк во втором массиве: ");
int m2 = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов во втором массиве: ");
int n2 = int.Parse(Console.ReadLine());

int[,] array1 = new int[m1, n1];
int[,] array2 = new int[m2, n2];
randarr(array1);
randarr(array2);
printarr(array1);
Console.WriteLine();
printarr(array2);
Console.WriteLine();
int [,] array3 = prod(array1, array2);
printarr(array3);