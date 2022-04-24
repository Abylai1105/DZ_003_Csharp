//using System;
//using static System.Console;
//Console.Clear;

//int a;
Console.Write("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string p = a.ToString();
char[] ar = p.ToCharArray();
Array.Reverse(ar);
p = new string(ar);
string b = a.ToString();
Console.WriteLine(a < 10000 || a > 99999? "число не соответствует": b == p? "палиндром" : "не палиндром");