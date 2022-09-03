// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.


void FillMatrix(int[,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(1, 15);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

if (m<1 || n< 1)
{
    Console.WriteLine("Введены некорректные значения");
}
else 
{
    int[,]matrix = new int [m,n];
    FillMatrix(matrix);
    PrintArray(matrix);
    int indFirstRool = 0;
    int indLastRool = m - 1;
    int[]TempArray = new int [n];
    for (int i = 0; i < n; i++)
    {
        TempArray[i] = matrix[indFirstRool,i];
    }
    for (int i = 0; i < n; i++)
    {
        matrix[indFirstRool,i] = matrix[indLastRool,i];
    }
     for (int i = 0; i < n; i++)
    {
        matrix[indLastRool,i] = TempArray[i];
    }
    Console.WriteLine("Новый массив  ");
    PrintArray(matrix);
}