// программа принимает на вход число и возвращает сумму его цифр
int SumNun(int number)
{
    if (number > 0)
    {
        return number % 10 + SumNun(number/10);
    }
    return number% 10;
}
Console.WriteLine(SumNun(435));