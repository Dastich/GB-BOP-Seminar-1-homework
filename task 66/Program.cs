// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfDigit(int m,int n)
{
   if(m>=n) return n;
   else
   {
    int sum=m+SumOfDigit(m+1,n);
    return sum;
   }
}

int m=ReadInt("Введите число m: ");
int n=ReadInt("Введите число n: ");
int result=SumOfDigit(m,n);
Console.WriteLine($"Результат сложения чисел от {m} до {n} = {result}");