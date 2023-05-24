// Задать двумерный массив. Программа которая поменяет строки и столбцы или выдаст сообщение что это невозможно
int[,] CreateTwoDimArray(int firstLength, int secondLength)
{
    int[,] array = new int[firstLength, secondLength];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);

    return array;
}

void ChangeArray(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j>i)
            {
                temp = array[i, j];
                array [i, j]= array[j, i];
                array [j, i]= temp;
            }
        }
    }        
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

int[,] array = CreateTwoDimArray(4, 4);
PrintArray(array);
ChangeArray(array);
Console.WriteLine(String.Empty);
PrintArray(array);


