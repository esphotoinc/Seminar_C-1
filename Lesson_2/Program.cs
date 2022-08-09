// 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int num = new Random().Next(10, 100);
// Console.WriteLine(num);
// if (num / 10 > num % 10)
// {
//     Console.Write(num / 10);
// }
// else 
// {
//     Console.Write(num % 10);
// }

// 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// Console.Clear();
// Console.Write("введите первое число:");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите второе число:");
// int M = Convert.ToInt32(Console.ReadLine());

// if (M % N == 0)
// {
//     Console.WriteLine("Второе число кратно первому");
// }
//  else
// {
//     Console.WriteLine($"Второе число не кратно первому, остаток от деления: {M % N}");
// }

// 4.Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine ());
// if (number%7 == 0 && number%23 ==0)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine("Не кратно");
// }

// 5. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.


// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 == num2*num2)
// {
//     Console.WriteLine("Первое число является квадртом второго");
// }
// else
// {
//     Console.WriteLine("Первое число не является квадртом второго");
// }
// if(num2 == num1*num1)
// {
//     Console.WriteLine("Второе число явлеятся квадратом первого");
// }
// else
// {
//       Console.WriteLine("Второе число не явлеятся квадратом первого");
// }