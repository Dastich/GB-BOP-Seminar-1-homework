// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​
// Например, задан массив:
// ​
// 1 4 7 2
// ​
// 5 9 2 3
// ​
// 8 4 2 4
// ​
// 1 7 -> такого числа в массиве нет

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
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
}

int[,] FillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    var rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(-10,10);
        }
    }
    return array;
}

void FindNumberOnMatrix(int[,] array,int rowsfind,int columnsfind)
{
    if(rowsfind>array.GetLength(0)||columnsfind>array.GetLength(1))
    {
        Console.WriteLine("Числа с такой позиций в массиве нет");
    }
    else
    {
        Console.WriteLine(array[rowsfind,columnsfind]);
    }
}

const int ROWS=5;
const int COLUMNS=7;
int[,] matrix=FillArray(ROWS,COLUMNS);
PrintMatrix(matrix);
int rowspos=ReadInt("Введите номер строки: ");
int columnspos=ReadInt("Введите номер столбца: ");
FindNumberOnMatrix(matrix,rowspos,columnspos);

