// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"n={n}, m={m}");
if (m>n)
for (int i = n; i <= m; i++)
    Console.Write($" {i}");
else
    for (int i = m; i <= n; i++)
        Console.Write($" {i}");
 