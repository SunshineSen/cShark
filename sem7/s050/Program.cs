/* Напишите программу, 
которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет. */
int lineM = Read("Введите позицию в строке: ");
int columN = Read("Введите позицию в столбце: ");
int[,] numbers = new int[6, 8];
CreateRandomTwoDimArray(numbers);
PrintArrayTwoDim(numbers);

if (lineM < numbers.GetLength(0) && columN < numbers.GetLength(1)) System.Console.WriteLine(numbers[lineM, columN]);
else System.Console.WriteLine($"{lineM}{columN} -> такого числа в массиве нет");

void CreateRandomTwoDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void PrintArrayTwoDim(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}


int Read(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
