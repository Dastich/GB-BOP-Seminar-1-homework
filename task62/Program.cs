// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4

// 12 13 14 5

// 11 16 15 6

// 10 9 8 7

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

int[,] FillSpiral(int n)
{ int[,] result=new int[n,n];
    int count=1;
    int offset=0;
    for(int i=0;i<n;i++)
    {
        result[0,i]=count;
        count++;
    }
    count--;
    for (int i=0;i<n;i++)
    {
        result[i,n-1]=count;
        count++;
    }
    count--;
    for(int i=n-1;i>=0;i--)
    {
        result[n-1,i]=count;
        count++;
    }
    count--;
    for(int i=n-1;i>0;i--)
    {
        result[i,0]=count;
        count++;
    }
    offset++;
    for(int i=0+offset;i<n-offset;i++)
    {
        result[0+offset,i]=count;
        count++;
    }
    count--;
    for (int i=0+offset;i<n-offset;i++)
    {
        result[i,n-1-offset]=count;
        count++;
    }
    count--;
    for(int i=n-1-offset;i>=0+offset;i--)
    {
        result[n-1-offset,i]=count;
        count++;
    }
    return result;


}
int[,] result = FillSpiral(4);
PrintMatrix(result);


