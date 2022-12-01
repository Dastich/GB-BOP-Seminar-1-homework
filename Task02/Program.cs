Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2)
    Console.WriteLine("Введеные числа равны");
else
{
    if (number1 > number2)
        Console.WriteLine("Max=" + number1 + " Min=" + number2);
    else
        Console.WriteLine("Max=" + number2 + " Min=" + number1);
}
