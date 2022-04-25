using System;
using static System.Console;
Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(ReadLine());
for(int N = 1; N <= number; N++)
{
    Console.Write($"{N*N*N}, ");
}