//Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива(в пределах всего массива).

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
void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)

            for (int a = 0; a < array.GetLength(0); a++)
                for (int b = 0; b < array.GetLength(1); b++)
                    if (array[a, b] < array[i, j] & a == i) 
                    {
                        int temp = array[i, j];
                        array[i, j] = array[a, b];
                        array[a, b] = temp;
                    }
}

Console.Write("Задайте количество строк в массиве: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];
randarr(array);
printarr(array);
SortArray(array);
Console.WriteLine();
printarr(array);