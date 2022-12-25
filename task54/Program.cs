// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7

// 2 3 5 9

// 2 4 4 8

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

void SortMatrix(int[,] matrix)
{
    int min = 0;
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            min = matrix[i, j];
            int minj = j;
            for (int k = j; k < matrix.GetLength(1); k++)
            {
                if (min > matrix[i, k])
                {
                    min = matrix[i, k];
                    minj = k;
                }

            }
            temp = matrix[i, j];
            matrix[i, j] = min;
            matrix[i, minj] = temp;
        }
    }
}


int rows = ReadInt("Введите число строк матрицы: ");
int columns = ReadInt("Введите число столбцов матрицы: ");
int[,] matrix = FillArray(rows, columns);
PrintMatrix(matrix);
SortMatrix(matrix);
PrintMatrix(matrix);

