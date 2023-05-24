/* Задайтедвумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.*/

int[,] CreateTwoDimAray (int firstLength, int secondLength)
{
    int[,] array = new int[firstLength, secondLength];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);

    return array;
}

(int x, int y) MinIndex(int[,] array)
{
    int minI = 0;
    int minJ = 0;
    for ( int i = 0; i < array.GetLength(0); i++)
    {
        for ( int j =0; j < array.GetLength(1); j++)
        {
            if (array[i, j] <  array [minI, minJ])
            {
                minI = i; minJ = j;

            }
        }
    }
    return (minI, minJ);
}

int[,] DelColAndRows(int[,] array, (int x, int y) min)
{
    int shiftX = 0;
    int shiftY = 0;
    int[,] array_new = new int [array.GetLength(0)-1, array.GetLength(1)-1];
    for ( int i = 0; i < array_new.GetLength(0); i++)
    {
        if ( i == min.x) shiftX=1;
        for ( int j =0; j < array_new.GetLength(1); j++)
        {
            if ( j == min.y) shiftY=1;
            array_new[i, j] = array [i + shiftX, j + shiftY];
        }
    }
    return array_new;
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
int[,] array = CreateTwoDimAray (4, 4);
PrintArray(array);
int[,] Newarray = DelColAndRows(array, MinIndex(array));
Console.WriteLine(String.Empty);
PrintArray(Newarray);


