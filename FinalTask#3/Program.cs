/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine("Input two non-negative numbers (m and n)");
Console.Write("m -> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n -> ");
int n = Convert.ToInt32(Console.ReadLine());
while (true)
{
    if (m < 0 || n < 0)
    {
        Console.WriteLine("Input a non-negative numbers");
        Console.Write("m -> ");
        m = Convert.ToInt32(Console.ReadLine());
        Console.Write("n -> ");
        n = Convert.ToInt32(Console.ReadLine());
    }
    break;
}
Console.WriteLine();
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Recursion(m, n)}");

int Recursion (int M, int N)
{
    if (M == 0) return N + 1;
    else if (M > 0 && N == 0) return Recursion(M - 1, 1);
    else return Recursion(M - 1, Recursion(M, N - 1));
}