// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N

void PrintNumber(int number)
{
    if (number !=1)
    {
        PrintNumber(number-1);
    }
    Console.WriteLine(number);
}
PrintNumber(5);

