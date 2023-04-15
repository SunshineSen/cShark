//  выводит третью цифру числа или сообщает, что ее нет
int Numb(string message)
{
    System.Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}
bool NotThree (int number)
{
    if (number < 100)
    {
        System.Console.WriteLine("третьей цифры нет");
        return false;
    }
    return true;
}
int ThirdNum (int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
int number = Numb("введите число ");
if (NotThree (number))
{
    System.Console.WriteLine(ThirdNum(number));
}