// принимает на вход число и выдаёт сумму цифр в числе.
int SumNumb(int number)
{
    int sum = 0;

while (number > 0)
{
    sum+= number %10;
    number = number /10;
}
return sum;
}

Console.WriteLine("введите число");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"сумма цифр в числе: {SumNumb(number)}");
