﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}

int SumOfOdd(int[] array)
{
    int sum=0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i%2!=0)
        {
            sum+=array[i];
        }
    }
    return sum;
}


int[] array = new int[6];
FillArray(array);
Console.WriteLine($"{string.Join(" ", array)}");
int result=SumOfOdd(array);
Console.WriteLine($"Сумма чисел на нечетных позициях массива равна {result}");