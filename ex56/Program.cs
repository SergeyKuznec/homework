//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

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
int sumMinArr(int[,] array)
{
    int indexi = 0;
    int sumMin = array[0,0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
    int sum = 0;
       for (int j = 0; j < array.GetLength(1); j++) 
       {
            sum = sum + array[i,j];
       }
    if (sumMin > sum)
    {
        sumMin = sum;
        indexi = i;
    }
    }
return indexi;         
}
Console.Write("Задайте количество строк в массиве: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов в массиве: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];
randarr(array);
printarr(array);
int index = sumMinArr(array);
Console.WriteLine();
Console.WriteLine($"номер строки с минимальной суммой элементов {index + 0}");

