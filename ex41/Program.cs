Console.WriteLine($"введите количество чисел которые собираетесь ввести");
int numb = Convert.ToInt32(Console.ReadLine());
int count = 0;
int countpos(int a)
{
for(int i = 0; i < a; i++)
{
    int pr = Convert.ToInt32(Console.ReadLine());
    if (pr > 0) count++;
}
return count;
}
//for(int i = 0; i < numb; i++)
//{
//    int pr = Convert.ToInt32(Console.ReadLine());
//    if (pr > 0) count++;
//}
Console.WriteLine($"количество чисел больше 0 равно: {countpos(numb)}");