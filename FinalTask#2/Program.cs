/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Input two positive numbers (M and N)");
Console.Write("M -> ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("N -> ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"M = {M}; N = {N} -> {Rec(M, N)}");

int Rec(int m, int n)
{
    if (m == n) return m;
    return m + Rec(m + 1, n);
}