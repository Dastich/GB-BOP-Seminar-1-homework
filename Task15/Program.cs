Console.Write("Введите день недели: ");
int day =Convert.ToInt32(Console.ReadLine());
if(day<1||day>7);
{
    while(day<1||day>7)
    {
    Console.Write("Введенное число некорректно, введите верный день недели: ");
    day=Convert.ToInt32(Console.ReadLine());
    }
}
if(day>=1&&day<=5)
Console.WriteLine("Сегодня будний день :(");
else
Console.WriteLine("Сегодня выходной :)");