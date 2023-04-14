// случайное число из отрезка 10-99 и показывает наибольшую цифру числа
// без функции

// int number = new Random().Next(10, 100);
// int first = number/10;
// int second = number % 10;
// System.Console.WriteLine(number);
// if (first > second)
// {
//    System.Console.WriteLine(first);
// }
// else
// {
//    System.Console.WriteLine(second);
// }

// решение через массив

System.Console.WriteLine("min");
int min = ReadInt();

System.Console.WriteLine("max");
int max = ReadInt();

int number = GetRandomNumber(min, max);

if (GetFirtDigit(number) > GetSecondDigit(number))
{
    System.Console.WriteLine("first");
}
else
{
    System.Console.WriteLine("second");
}

int GetRandomNumber(int min, int max)
{
    return new Random().Next(min, max + 1);
}
System.Console.WriteLine(number);

int GetFirtDigit(int number)
{
    return number / 10;
}
int GetSecondDigit(int number)
{
    return number % 10;
}
int ReadInt()
{
    return int.Parse(Console.ReadLine());
}