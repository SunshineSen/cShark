// по заданному номеру четверти показывает диапазон возможных координат этой четверти
void Quart ( int range)
{
    if (range == 1)
    {
        System.Console.WriteLine(" x: 1, y: inf");
    }
    else if (range == 2)
    {
        System.Console.WriteLine("x: -inf, y: inf");
    }
    else if (range == 3)
    {
        System.Console.WriteLine("x: -inf, y: 1");
    }
    else if (range == 4)
    {
        System.Console.WriteLine("x: inf, y: -inf");
    }
    else 
    {
        System.Console.WriteLine("это не четверть");
    }
}
System.Console.WriteLine("введите число");
int Q = int.Parse(Console.ReadLine());
Quart((Q));