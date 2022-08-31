// Задайте двумерный массим размера m на n, каждый элемент находится
// по формуле A(mn) = m + n. Выведите полученный массив на экран

int Promt(string message)
{
    System.Console.Write (message);                      // Ввести значение
    int result  = Convert.ToInt32(Console.ReadLine());   // Считывает значение
    return result;                                       // Возвращает результат
}

int [,] FillArray(int numLine, int numCollumns)   //Функция создания массива по формуле
{
    int[,] matrix = new int [numLine, numCollumns];
    for (int i = 0; i < matrix.GetLength(0); i++)       // строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // столбец
        {
            matrix[i,j] = i+j;                          
        }
    }
    return matrix;
}

void PrintArray(int[,]matrix)                            // печать массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)       // строка
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // столбец
    {
        Console.Write($"{matrix[i,j]}\t");
    }
      Console.WriteLine();
    }
}

int[,] array = FillArray(Promt("Введите число строк "), Promt ("Введите число столбцов "));
PrintArray(array);
