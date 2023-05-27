//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
void SumMtoN(int M, int N)
{
    Console.Write(ResultSum(M - 1, N));
}
int ResultSum(int M, int N)
{
    int result = M;
    if (M == N)
        return 0;
    else
    {
        M++;
        result = M + ResultSum(M, N);
        return result;
    }
}
SumMtoN (2, 7);