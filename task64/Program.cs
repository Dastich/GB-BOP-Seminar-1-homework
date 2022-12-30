// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintDigit(int N, int count=1)
{
   
   if(count>N) return;
   else
   {
    PrintDigit(N,count+1);
    Console.Write(count+ " ");
   } 
}

int n=ReadInt("Введите число N: ");
PrintDigit(n);

