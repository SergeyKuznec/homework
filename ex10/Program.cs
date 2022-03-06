Console.WriteLine("введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int a = (number / 10) % 10;
Console.WriteLine(a);
