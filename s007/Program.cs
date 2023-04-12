// на вход трехзначное число, на выход последняя цифра этого числа
Console.Write("введите число ");
int number = int.Parse(Console.ReadLine());
if (number >= 100 && number < 1000)
{
    Console.WriteLine (number % 10);
}
else
{
    Console.WriteLine ("число не подходит");
}
