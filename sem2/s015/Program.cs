// принимает на вход цифру - день недели и проверяет является ли он выходным
int whatDay(string message)
{
    System.Console.Write(message);
    int D = int.Parse(Console.ReadLine());
    return D;
}
bool Weekend (int Day)
{
    if (Day > 5)
    {
        return true;
    }
    return false;
}
bool notDay (int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    System.Console.WriteLine("не день недели");
    return false;
}
int weekDay = whatDay ("Введите день недели ");
if (notDay(weekDay))
{
    if (Weekend(weekDay))
    {
        System.Console.WriteLine("выходной");
    }
    else {
        System.Console.WriteLine("будний день");
    }
}