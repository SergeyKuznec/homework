﻿int[] array = new int[8]; 
int len = array.Length;
int index = 0;
while(index < len)
{
    array[index] = Convert.ToInt32(Console.ReadLine());;
    index++;
}
for (int i=0; i<len; i++)
{
Console.Write(array[i]);
}
