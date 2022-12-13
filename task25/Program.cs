// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Не использовать Math.Pow() и аналоги!

int GetNumber(string message)
{
    Console.Write($"{message}");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Pow(int numberA, int numberB)
{
    int result=1;
    while(numberB!=0)
    {
        result*=numberA;
        numberB--;
    }
    return result;
}

int numberA=GetNumber("Введите число А: ");
int numberB=GetNumber("Введите число B: ");
int result=Pow(numberA,numberB);
Console.WriteLine($"Результат возведения числа {numberA} в степень {numberB} равен {result}");