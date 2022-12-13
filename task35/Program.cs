void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 151);
    }
}

int CountDigitOfRange(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100)
        {
            count++;
        }
    }
    return count;
}




int[] array = new int[123];
FillArray(array);
Console.WriteLine($"{string.Join(" ", array)}");
int result=CountDigitOfRange(array);
Console.WriteLine($"В массиве {result} чисел в интервале [10;99]");