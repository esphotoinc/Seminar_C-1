// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


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


// int[] myArray = CreateRandomArray(5, 100, 1000);


// int count = 0;
// for (int i = 0; i < myArray.Length; i++)
// {
//     if(myArray[i]%2 == 0)
//     {
//         count ++;
//     }
// }
// ShowArray(myArray);
// Console.WriteLine(count);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

// int[] myArray = CreateRandomArray(5, 1, 10);
// ShowArray(myArray);

// int sum = 0;
// for (int i = 1; i < myArray.Length; i = i + 2)
// {
//     sum += myArray[i];   
// }

// Console.WriteLine ($"Сумма элементов нанечетных позициях {sum}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


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

// int[] myArray = CreateRandomArray(5, 1, 10);
// ShowArray(myArray);

// int min = myArray[0];
// int max = myArray[0];
// int result = 0;


// for (int i = 0; i < myArray.Length ; i++)
//  {
//     if (myArray[i] < min)
//     {
//         min = myArray[i];
//     }
//     else if (myArray[i] > max)
//     {
//         max = myArray[i];
//     }
//     result = (max -min);
// }

// Console.Write($"Разница между максимальным и минимальным равно {result}");
