// на вход число и прверяет кратно ли 7 и 23
Console.Write("введите число ");
int a = int.Parse(Console.ReadLine());

if (a%7 == 0 & a%23 == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("не кратно ");
}