//Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве

int[] mass = new int[10];
void fill(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
       arr[i] = new Random().Next(100,999); 
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
for (int i = 0; i < mass.Length; i++)
    {
        if(mass[i] % 2 == 0) count++ ; 
    }
Console.WriteLine();    
Console.WriteLine($"количество четных чисел равно: {count}");

