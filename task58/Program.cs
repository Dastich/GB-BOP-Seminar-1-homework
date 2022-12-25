// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// и

// 1 5 8 5

// 4 9 4 2

// 7 2 2 6

// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10

// 20 81 8 6

// 56 8 4 24

// 10 6 24 49


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
        array[i, j] = rand.Next(1,10);
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
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] multiplicationOfMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] result=new int[firstMatrix.GetLength(0),firstMatrix.GetLength(1)];
    for(int i=0;i<result.GetLength(0);i++)
    {
        for(int j=0;j<result.GetLength(1);j++)
        {
          result[i,j]=firstMatrix[i,j]*secondMatrix[i,j];
        }
    }
    return result;
}

int rowsFirst = ReadInt("Введите число строк первой матрицы: ");
int columnsFirst=ReadInt("Введите число столбцов первой матрицы: ");
int rowsSecond=ReadInt("Введите число строк второй матрицы: ");
int columnsSecond=ReadInt("Введите число столбцов первой матрицы: ");

int[,] firstMatrix=FillArray(rowsFirst,columnsFirst);
int[,] secondMatrix=FillArray(rowsSecond,columnsSecond);
if(firstMatrix.GetLength(0)==secondMatrix.GetLength(0)&&firstMatrix.GetLength(1)==secondMatrix.GetLength(1))
{
PrintMatrix(firstMatrix);
PrintMatrix(secondMatrix);
int[,] result=multiplicationOfMatrix(firstMatrix,secondMatrix);
PrintMatrix(result);
}
else
{
    Console.WriteLine("Матрицы введены с разным количеством столбцов и строк");
}