// принимает на вход число (А) и выдаёт сумму чисел от 1 до А
int SummA (int A)
{
    int result = 0;
    for (int i = 1; i <= A; i++)
        result += i;
    return result;

}
System.Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine());
Console.WriteLine (SummA(A));