Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 & number % 23 == 0)
{
  Console.WriteLine("число одновременно кратно 7 и 23");  
}
else if (number % 7 == 0)
{
    Console.WriteLine("число кратно 7");
}
else if (number % 23 == 0)
{
    Console.WriteLine("число кратно 23");
}
else
{
    Console.WriteLine("число не кратно");
}