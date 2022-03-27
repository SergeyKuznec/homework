Console.WriteLine("введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int B = Convert.ToInt32(Console.ReadLine());
int comp = 1;
for (int i = 1; i <= B; i++)
{
    comp = comp * A;
}
Console.WriteLine(comp);