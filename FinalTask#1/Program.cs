﻿/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.WriteLine("Hello! Input the number N please");
int N = Convert.ToInt32(Console.ReadLine());
while (true)
{
    if (N <= 0)
    {
        Console.WriteLine("Input a positive number");
        N = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        Console.WriteLine($"N = {N} -> '{Rec(N)}'");
        break;
    }
}

string Rec(int N)
{
    if (N == 1) return Convert.ToString(N);
    return Convert.ToString(N) + ", " + Rec(N - 1);
}