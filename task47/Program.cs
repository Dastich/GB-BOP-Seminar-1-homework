// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​
// m = 3, n = 4.
// ​
// 0,5 7 -2 -0,2
// ​
// 1 -3,3 8 -9,9
// ​
// 8 7,8 -7,1 9

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] FillArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    double temp=0;
    var rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp=rand.Next(-100,100);
            temp/=10;
            array[i, j] = temp;
        }
    }
    return array;
}

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

int rows=ReadInt("Введите число строк: ");
int columns =ReadInt("Введите число столбцов: ");
double[,] matrix=FillArray(rows,columns);
PrintMatrix(matrix);