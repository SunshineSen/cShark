﻿//  двумерный массив размером m×n, заполненный случайными вещественными числами
int lineM = ReadInt("Введите m: ");
int columN = ReadInt("Введите n: ");
double[,] numbers = new double[lineM, columN];
CreateRandomArray(numbers);
PrintArray(numbers);

void CreateRandomArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 99) / 10.0;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}