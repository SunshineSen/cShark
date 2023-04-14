// принимает два числа и проверяет является ли первое квадратом второго
Console.Write("a=");
int a = int.Parse(Console.ReadLine());
Console.Write("b=");
int b = int.Parse(Console.ReadLine());
if (a == b*b)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}