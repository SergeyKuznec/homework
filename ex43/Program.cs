﻿Console.WriteLine("задайте b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("задайте k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("задайте b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("задайте k2");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = (b2 - b1)/(k1 - k2);
double y = (k1*x) + b1;
Console.WriteLine($"решением являют числа {x:0.00} и {y:0.00}");