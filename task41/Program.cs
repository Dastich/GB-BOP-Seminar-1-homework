// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода слова "stop"

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

Console.Write("Введите число или stop:");
string number=Console.ReadLine();
int count=0;
while(number!="stop")
{
    int numberdigit=Convert.ToInt32(number);
    if(numberdigit>0)
    count++;
    Console.Write("Введите число или stop:");
    number=Console.ReadLine();
}
Console.WriteLine($"Было введено {count} чисел больше нуля");

