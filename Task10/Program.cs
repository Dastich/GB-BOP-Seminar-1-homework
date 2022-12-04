// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите число: ");
int number=Convert.ToInt32(Console.ReadLine());
if(number>1000||number<100);
{
    while(number>=1000||number<100)
    {
    Console.Write("Введенное число некорректно, введите трехзначное число: ");
    number=Convert.ToInt32(Console.ReadLine());
    }
}
int number1=number/100;
int number3=number%10;
int number2=(number-number1*100-number3)/10;
Console.WriteLine($"Вторая цифра:{number2}");