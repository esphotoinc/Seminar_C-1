// Задание 2.
// Задайте двумерный массив. Найдите элементы, у которых обе поизиции - четные, и замените эти элементы
// на их квадраты.

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

int[,] ConertToSqr(int [,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++);
        {
            if (i%2 == 0 && j%2 == 0 )
        }
    
    }
}


int[,] array = FillArray(Promt("Введите число строк "), Promt ("Введите число столбцов "));
PrintArray(array);

void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1, 15);
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

int[,] matrix = new int[3, 3];

FillMatrix(matrix);
PrintArray(matrix);

System.Console.WriteLine("Input a number: ");
int element = int.Parse(Console.ReadLine() ?? "0");
findElem(matrix, element);


void findElem (int[,] matrix, int element)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(element == matrix[i, j])
            {
              System.Console.WriteLine($"Entered number is on the [{i}, {j}] position");
              return;
            }
        }

    }
    System.Console.WriteLine($"There is no such element in this matrix");

    
}

