// на вход пятизначное число, проверить палиндром или нет
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int Poly = number.Length;

if (Poly == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - число - палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - не палиндром");
    }
}
else
{
    Console.WriteLine($"введеное число не является пятизначным");
}
