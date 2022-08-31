// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] a = new double[5, 10];

// Random random = new Random();
// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         a[i, j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
//         Console.Write("{0,6:F2}", a[i, j]);
//     }
//     Console.WriteLine();
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.WriteLine("Введите размеры массива");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
 
// for (int i = 0; i < array.GetLength(0); i++) 
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//         array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
// }
 
// for (int i = 0; i < array.GetLength(0); i++) 
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//         Console.Write(array[i,j] + "\t  ");
//         Console.WriteLine();
// }
 
//  Console.WriteLine("Введите координаты");
//  int a = Convert.ToInt32(Console.ReadLine());
//  int b = Convert.ToInt32(Console.ReadLine());
//  if (a>m && b>n)
//  Console.WriteLine("такого числа нет");
//  else
//  {
//  object c = array.GetValue(a,b);
//  Console.WriteLine(c);
//  }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int[,] massiv = new int[3,7];
// Random sluchay = new Random();
// double numLine = 0;
// for (int i = 0; i < massiv.GetLength(0); i++)
// {
// for (int j = 0; j < massiv.GetLength(1); j++)
// {
// massiv[i,j] = sluchay.Next(1, 9);
// Console.Write($"{massiv[i, j]}\t");
// }
// Console.WriteLine();
// numLine++;
// }
// Console.Write("Среднее арифметическое каждого столбца: ");
// int sum = 0;
// for (int j = 0; j < massiv.GetLength(1); j++)
// {
// for (int i = 0; i < massiv.GetLength(0); i++)
// {
// sum=sum+massiv[i,j];
// }
// Console.Write("{0,6:F1}", sum/numLine );
// sum = 0;
// }