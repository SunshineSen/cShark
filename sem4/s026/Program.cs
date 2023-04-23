// принимает на вход число и выдаёт количество цифр в числе.
int Numb (int number)
{
    int count = 1;
    while (number >9)
    {
        number/=10;
        count++;
    }
    return count;
}
System.Console.WriteLine("введите число ");
int N = int.Parse(Console.ReadLine());
System.Console.WriteLine("количество элементов в числе:"+ Numb(N));
