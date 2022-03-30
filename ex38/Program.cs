//Задача 38. Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

double[] mass = new double[10];
void fill(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
       arr[i] = new Random().NextDouble() + new Random().Next(-99, 99); 
    }
    
}
void print(double[] ar)
{
    for (int i = 0; i < ar.Length; i++)
    {
        Console.Write($"{ar[i]}, "); 
    }
}
fill(mass);
print(mass);
double min = 100;
double max = -100;
for (int i = 0; i < mass.Length; i++)
    {
        if(mass[i] < min) min = mass[i];
        if(mass[i] > max) max = mass[i];
    }
Console.WriteLine();    
Console.WriteLine($"разница между мкаксимальным {max} и минимальным {min} вечественным числом массива равна: {max - min}");