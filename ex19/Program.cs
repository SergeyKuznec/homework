Console.WriteLine("Введител пятизначное число");
string number = Convert.ToString(Console.ReadLine());
bool a = true;
for (int i =0; i < 2; i++)
{
    if (number[i] != number[number.Length - i -1])
    {
        a = false;
        break;
    }
}
if (a == true)
{
    Console.WriteLine("Полиндром");
}
else
{
    Console.WriteLine("Не полиндром");
}