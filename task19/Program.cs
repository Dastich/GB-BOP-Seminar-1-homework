// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите пятизначное  число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number < 10000 || number > 99999)
{
    Console.Write("Введенное число не подходит, введите число заново: ");
    number = Convert.ToInt32(Console.ReadLine());
}
int number5 = number % 10;
int number4 = number / 10 % 10;
int number2 = number / 1000 % 10;
int number1 = number / 10000;
if (number1 == number5&&number2 == number4)
{

        Console.WriteLine($"Число {number}  является палиндромом");   
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом");
}

// Console.WriteLine($"Число {number} не является палиндромом");
