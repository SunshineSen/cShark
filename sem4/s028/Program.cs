// принимает на вход число N и выдаёт произведение чисел от 1 до N.
int CompN (int N)
{
    int result = 1;
    for (int i = 1; i <= N; i++)
        result *= i;
    return result;

}
System.Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
Console.WriteLine (CompN(N));