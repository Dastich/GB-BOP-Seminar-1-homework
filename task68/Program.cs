// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9


int FunctionAccerman(int m, int n)
{
    if(m==0)
    {
        return n+1;
    }
    else if(n==0)
    {
        return FunctionAccerman(m-1,1);
    }
    else
    {
        return FunctionAccerman(m-1, FunctionAccerman(m,n-1));
    }
        
    
}

int m=2;
int n=3;
Console.WriteLine(FunctionAccerman(m,n));