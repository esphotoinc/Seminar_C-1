// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

//  int[] CreateRandomArray(int N, int min, int max)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(min, max + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);

// int som_pos = 0;
// int som_neg = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i]> 0)
//     som_pos += myArray[i];
//     else 
//     som_neg += myArray[i];
// }

// Console.WriteLine ($"Сумма положительных равна {som_pos}, сумма негативных равна {som_neg}");

// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

//  int[] CreateRandomArray(int N, int min, int max)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(min, max + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);
// Console.WriteLine ("---------------------------------------");
// Changing(myArray);

// void Changing(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {

//         Console.Write($"{array[i] * -1 + " "}");
//     }
//     Console.WriteLine();


// }


// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// int[] CreateRandomArray(int N, int min, int max)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(min, max + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }


// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);
// Console.WriteLine ("Введите число для поиска");
// int find = int.Parse(Console.ReadLine());
// bool flag = false;

// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] == find)
//     {
//         flag = true;
//     }

// }
// if (flag == true)
// {
//     Console.WriteLine("Данное число присутсвует в массиве");
// }
// else
// {
//     Console.WriteLine("Данного числа нет в массиве");
// }

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

// int[] CreateRandomArray(int N, int min, int max)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(min, max + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }


// int[] myArray = CreateRandomArray(123, -500, 500);


// int count = 0;
// for (int i = 0; i < myArray.Length; i++)
// {
//     if(myArray[i] >= 10 && myArray[i] <= 99)
//     {
//         count ++;
//     }
// }
// ShowArray(myArray);
// Console.WriteLine(count);


// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// int[] CreateRandomArray(int N, int min, int max)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(min, max + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }



// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);

// int result = 0;
// int a = myArray.Length - 1;
// for (int i = 0; i < myArray.Length / 2; i++)
// {
//     result = myArray[i] * myArray[a];
//     a -= 1;
//     Console.Write($"[{String.Join(",", result)}]");
// }
// if (myArray.Length % 2 != 0)
// {
//     Console.Write($"[{String.Join(",", myArray[myArray.Length / 2])}]");
// }
