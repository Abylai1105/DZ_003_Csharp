//using System;
//using static System.Console;
//Console.Clear;

Console.Write("Введите координаты через пробел: ");
string[] a1 = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

int x1 = int.Parse(a1[0]);
int y1 = int.Parse(a1[1]);
int z1 = int.Parse(a1[2]);
int x2 = int.Parse(a1[3]);
int y2 = int.Parse(a1[4]);
int z2 = int.Parse(a1[5]);

double.result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Растояние между точками: {result}");
