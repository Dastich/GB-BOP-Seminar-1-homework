// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int PrintDigit1ForN(int N)
{
    if (N == 1) return 1;
    Console.Write(PrintDigit1ForN(N - 1)+" ");
    return N;

}

int N = ReadInt("Введите число N: ");
Console.WriteLine(PrintDigit1ForN(N));