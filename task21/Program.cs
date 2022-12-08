// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите x(1)");
int x1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y(1)");
int y1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z(1)");
int z1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x(2)");
int x2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y(2)");
int y2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z(2)");
int z2=Convert.ToInt32(Console.ReadLine());

double res=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
Console.WriteLine($"Расстояние между двумя точками равно {res:f2}");