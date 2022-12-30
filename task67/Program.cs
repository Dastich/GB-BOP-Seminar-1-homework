// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9 

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfDigit(int N)
{
    int result=0;
    if(N==0) return 0;
    else
    {
        result+=N%10+SumOfDigit(N/10);
        return result;
    }
    
}

int n=ReadInt("Введите число: ");
int result=SumOfDigit(n);
Console.WriteLine(result);