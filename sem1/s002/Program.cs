// на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("a= ");
int a = int.Parse(Console.ReadLine());
Console.Write("b= ");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.Write("максимальное" );
    Console.Write(a);
}
else 
{
    Console.Write ("максимальное ");
    Console.Write(b);
}