// принимает два числа А и В и возводит число А в степень В с помощью рекурсии
int PowNumber (int firstNumber, int secondNumber)
{
    if (secondNumber > 0)
    {
        return firstNumber * PowNumber(firstNumber, secondNumber -1);
    }
    return 1;
}
System.Console.WriteLine(PowNumber(2, 10));