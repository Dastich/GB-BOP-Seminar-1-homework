// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

(double, double) GetLineCoordinates(string firstName, string secondName)
{
    Console.Write($"Введите {firstName} ");
    double firstcord = Convert.ToDouble(Console.ReadLine());
    Console.Write($"Введите {secondName} ");
    double secondcord = Convert.ToDouble(Console.ReadLine());
    return (firstcord, secondcord);
}
(double k1, double b1) = GetLineCoordinates("k1", "b1");
(double k2, double b2) = GetLineCoordinates("k2", "b2");
double x = (b1 - b2) / (k1 - k2) *-1;
double y = k2*x+b2;
Console.WriteLine($"Точкой пересечения прямых y={k1}x+{b1} и y={k2}x+{b2} = ({x},{y})");
