// на вход трехзначное число, на выход последняя цифра этого числа
Console.Write("введите трехзначное число ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine (number % 10);