// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int GetNumber(string message)
{
    Console.Write($"{message}");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int GetSumOfDigit(int number)
{
    int sumofdigit=0;
    while(number!=0)
    {
        sumofdigit+=number%10;
        number/=10;
        
    }
    return sumofdigit;
}

int number =GetNumber("Введите число: ");
int result=GetSumOfDigit(number);
Console.WriteLine($"Сумма цифр числа {number} равна {result} ");