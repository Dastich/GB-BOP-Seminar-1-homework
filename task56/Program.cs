// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int[,] FillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    var rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int FindMinOfRows(int[,] matrix)
{
    int min;
    int sumoOfRows = 0;
    int minindex;

    for (int k = 0; k < matrix.GetLength(1); k++)
    {
        sumoOfRows += matrix[0, k];
    }
    min = sumoOfRows;
    minindex = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        sumoOfRows = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumoOfRows += matrix[i, j];
        }
        if (sumoOfRows < min)
        {
            min = sumoOfRows;
            minindex = i;
        }
    }
    return minindex;
}






int rows = ReadInt("Введите число строк матрицы: ");
int columns = ReadInt("Введите число столбцов матрицы: ");
int[,] matrix = FillArray(rows, columns);
PrintMatrix(matrix);
int result = FindMinOfRows(matrix)+1;
Console.WriteLine($"Строка с наименьшей суммой элементов {result}");