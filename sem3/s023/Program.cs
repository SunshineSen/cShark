// принимает число N и выводит таблицу квадратов от 1 до N
void CubeT(int N)
{
    for (int i = 1; i <= N; i++)
    {
        System.Console.WriteLine(" " + Math.Pow(i, 3));
    }
}

System.Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
CubeT(N);