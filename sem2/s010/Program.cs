// на вход трехзначное число и показывает вторую цифру

int Numb(string message)
{
    System.Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int number = Numb("Введите число ");
if (number < 100 | number >= 1000)
{
    System.Console.WriteLine("неверное число ");
    return;
}
int a = number/10%10;
System.Console.WriteLine($"вторая цифра '{a}'" ); 

