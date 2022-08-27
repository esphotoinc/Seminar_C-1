// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(" ", array));

// int[] reversArray = ReversArray2(array);
// Console.WriteLine(String.Join(" ", reversArray));

// ReversArray1(array);
// Console.WriteLine(String.Join(" ", array));

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// void ReversArray1 (int[] inArray)
// {
//     for (int i = 0; i < inArray.Length/2; i++)
//     {
//         int k = inArray[i];
//         inArray[i] = inArray[inArray.Length - 1 -i];
//         inArray[inArray.Length - 1 -i] = k;
//     }

// }

// int[] ReversArray2(int[]inArray)
// {
//     int[] result = new int [inArray.Length];
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         result[i] =inArray[inArray.Length - 1 -i];
//     }
//     return result;
// } 

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

// 1. Решение стандартным способом
//  Console.Write("введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
//  Console.Write("введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
//  Console.Write("введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int sum12 = (num1+num2);
// int sum23 = (num2+num3);
// int sum13 = (num1 + num3);
// if( num1 < sum23 && num2 < sum13 && num3< sum12)
// {
//     Console.WriteLine("треугольник существует");
// }
// else Console.WriteLine("треугольник не существует");

 // 2. Решение через массив 
 
// Console.Clear();
// Console.Write("Введите стороны треугольника через пробел: ");

// string[] st = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

// if(IsTriangle(int.Parse(st[0]),int.Parse(st[1]),int.Parse(st[2])))
// {
// Console.WriteLine("Да");
// }
// else
// {
// Console.WriteLine("Нет");
// }



// bool IsTriangle(int a,int b,int c)
// {
// return (((a+b)>c)&&((a+c)>b)&&((b+c)>a));
// }

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.


// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.


// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.