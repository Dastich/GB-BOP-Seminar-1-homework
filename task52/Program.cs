double[,] CreateAndFillArray(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"Введите число в ячейке matrix[{i}],[{j}]: ");
            matrix[i, j] = Convert.ToDouble(Console.ReadLine());

        }
    }
    return matrix;

}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void AverageOfColumns(double[,] matrix)
{
double result=0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        result+=matrix[j,i];
    }
    Console.Write(result/matrix.GetLength(1)+" ");
    result=0;
}
}

int rows = ReadInt("Введите число строк: ");
int columns = ReadInt("Введите число столбцов: ");
Console.WriteLine();
double[,] matrix = CreateAndFillArray(rows, columns);
PrintMatrix(matrix);
AverageOfColumns(matrix);