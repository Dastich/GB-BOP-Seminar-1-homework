// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
int CountofEven(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum++;
        }
    }
    return sum;
}

int[] array = new int[10];
FillArray(array);
Console.WriteLine($"{string.Join(" ",array)}");
int result=CountofEven(array);
Console.WriteLine($"Колличество четных чисел в массиве равно {result}");