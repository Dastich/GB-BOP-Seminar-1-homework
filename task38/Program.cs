// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 101);
    }
}

int DifferentMinAndMax(int[] array)
{
    int min=array[0];
    int max=array[0];
    for(int i=0;i<array.Length;i++)
    {
        if(array[i]>max) 
        {
            max=array[i];
        }
        if(array[i]<min) 
        {
            min=array[i];
        }
    }
    int result=max-min;
    return result;
}

int[] massive=new int[10];
FillArray(massive);
Console.WriteLine($"{string.Join(" ",massive)}");
int result=DifferentMinAndMax(massive);
Console.WriteLine($"Разница между максимальным и минимальным элементов равна {result}");
