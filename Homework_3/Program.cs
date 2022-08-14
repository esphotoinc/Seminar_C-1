// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.Clear();
// Console.WriteLine ("Введите пятизначное число ");
// int number = Convert.ToInt32(Console.ReadLine());
// int first = (number/10000);
// int second = ((number/1000)%10);
// int fourth = ((number%100)/10);
// int fifth = (number%10);

// if ((number>9999) && (number <100000))
// {
//     if ((first == fifth) && (second == fourth))
//     {
//         Console.WriteLine("Число является палиндромом");
//     }
    
//     else 
//     {
//         Console.WriteLine("Число не является палиндромом");
//     }
// }
// else
// {
//     Console.WriteLine("Введите корректное число");
// }


// Задача 21.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.Clear();
// Console.Write("Введите X1 ");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write("Введите Y1 ");
// int y1 = int.Parse(Console.ReadLine());
// Console.Write("Введите Z1 ");
// int z1 = int.Parse(Console.ReadLine());
// Console.Write("Введите X2 ");
// int x2 = int.Parse(Console.ReadLine());
// Console.Write("Введите Y2 ");
// int y2 = int.Parse(Console.ReadLine());
// Console.Write("Введите Z2 ");
// int z2 = int.Parse(Console.ReadLine());

// // Math.Sqrt - функция для нахождения квадрата числа

// double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y1, 2) + Math.Pow(z1 - z1, 2));


// // d:f3 - округление до 3 символа после запятой
// Console.WriteLine($"d={d:f3}");

// // Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// // 1 вариант.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int cycle = 1;
int cycleCube = Convert.ToInt32(Math.Pow(cycle, 3));
int max = Convert.ToInt32(Math.Pow(num, 3));

while (cycleCube < max)
{
    {
        Console.WriteLine($"cycle ={cycle}");

    }

    cycle = cycle++;
    
}

// // 2 вариант.

// void Cube(int[] cube){
//   int counter = 0;
//   int length = cube.Length;
//   while (counter <  length){
//     cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
//     counter++;
//   }
// }

// void PrintArry(int[] coll){
//   int count = coll.Length;
//   int index = 0;
//   while(index < count){
//     Console.Write(coll[index]+ " ");
//     index++;
//   }
// } 

// int[] arry = new int[cube+1];
// Cube(arry);
// PrintArry(arry);