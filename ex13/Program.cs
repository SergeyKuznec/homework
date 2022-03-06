Console.WriteLine("введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 % number2 == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("остаток " + (number1 % number2));
}