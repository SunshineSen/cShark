//  на вход два числа (A и B) и возводит число A в натуральную степень B
int Numb(int A, int B)
{
    int count = 1;
    for (int i = 0; i < B; i++)
    {
        count *= A;
    }
    return count;
}
bool NotN(int B)
{
    if (B < 0)
    {
        System.Console.WriteLine("это не натуральное число");
        return false;
    }
    return true;
}


Console.WriteLine("введите число A");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("введите число B");
int B = int.Parse(Console.ReadLine());
if (NotN(B))
{
    System.Console.WriteLine($"Число {A} в степени {B} равно {Numb(A, B)}");
}
