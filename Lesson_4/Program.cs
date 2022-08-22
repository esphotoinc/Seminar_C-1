// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int GetSumNums (int number)
// {
//     int sum = 0;
//     for (int i = 0; i<=number; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// Console.WriteLine ("Введите число");
// int num = int.Parse (Console.ReadLine());
// Console.WriteLine ($"Сумма цифра = {GetSumNums(num)}");

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.


// Console.Write("введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 0;
// if (num == 0)
// Console.Write("1");
// else
// {
// while(num!= 0)
// {
// num = num / 10;
// i++;
// }
// Console.Write(i);
// }



// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// int GetSumNums (int number)
// {
//     int sum = 1;
//     for (int i = 1; i<=number; i++)
//     {
//         sum *= i;
//     }
//     return sum;

// }

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Проивзедение чисел = {GetSumNums(num)}");

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array1 = new int [8];
// Random rnd = new Random();
// for (int i = 0; i < 8; i++ )
// {
//     array1[i] = rnd.Next(0,2);
//     Console.Write (array1[i]+ " ");
// }
