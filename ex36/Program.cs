//Задача 36. Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] mass = new int[10];
void fill(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
       arr[i] = new Random().Next(0,10); 
    }
    
}
void print(int[] ar)
{
    for (int i = 0; i < ar.Length; i++)
    {
        Console.Write($"{ar[i]}, "); 
    }
}
fill(mass);
print(mass);
int count = 0;
for (int i = 1; i < mass.Length; i = i + 2) 
    {
         count += mass[i];
    }
Console.WriteLine();    
Console.WriteLine($"сумма чисел на нечетных позициях равна: {count}");
