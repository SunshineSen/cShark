// случайное число из отрезка 10-99 и показывает наибольшую цифру числа
int number = new Random().Next(10, 100);
int first = number/10;
int second = number % 10;
System.Console.WriteLine(number);
if (first > second)
{
    System.Console.WriteLine(first);
}
else
{
    System.Console.WriteLine(second);
}
