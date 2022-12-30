// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int M= 2;
int N= 8;

int PrintDigit(int M,int N)
{
    if(M==N) return M;
    Console.Write(PrintDigit(M,N-1)+" ");
    return N;

}

Console.Write(PrintDigit(M,N));