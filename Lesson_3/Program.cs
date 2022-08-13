// 1. Задача с функцией

// void PrintQuarter(int x, int y)
// {

//     if (x > 0 && y > 0)
//     {
//         Console.WriteLine("1");
//     }
//     else if (x < 0 && y < 0)
//     {
//         Console.WriteLine("3");
//     }
//     else if (x > 0 && y < 0)
//     {
//         Console.WriteLine("4");
//     }
//     else if (x < 0 && y > 0)
//     {
//         Console.WriteLine("2");
//     }

//     else
//     {
//         Console.WriteLine("Ошибка");
//     }
// }

// Console.Write("Введите координаты X ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты Y ");
// int y = Convert.ToInt32(Console.ReadLine());
// PrintQuarter (x,y);

// // 2. Пример со switch

// Console.Write("Введите номер четверти ");
// int quarter = int.Parse(Console.ReadLine());
// void PrintQuarter(int quarter);

// {
//     switch (q)
//     {

//         case 1:
//             {

//                 Console.WriteLine("x>0;y>0");
//                 break;
//             }
//         case 2:
//             {

//                 Console.WriteLine("x<0;y>0");
//                 break;
//             }
//         case 3:
//             {

//                 Console.WriteLine("x>0;y<0");
//                 break;
//             }
//         case 4:
//             {

//                 Console.WriteLine("x<0;y<0");
//                 break;
//             }
//         default:
//             {
//                 Console.WriteLine("Введена неверная четверть");
//                 break;
//             }
//     }
// }

//  3. Напишите программу, которая на вход принимает координаты 2х точек и находит расстояние между ними в 2д пространстве.

// Console.Clear();
// Console.Write("Введите X1 ");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write("Введите Y1 ");
// int y1 = int.Parse(Console.ReadLine());
// Console.Write("Введите X2 ");
// int x2 = int.Parse(Console.ReadLine());
// Console.Write("Введите Y2 ");
// int y2 = int.Parse(Console.ReadLine());

// // Math.Sqrt - функция для нахождения квадрата числа

// double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y1, 2));

// // d:f3 - округление до 3 символа после запятой
// Console.WriteLine($"d={d:f3}");