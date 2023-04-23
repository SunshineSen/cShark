// задаёт массив из 8 элементов и выводит их на экран.
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }
}

void PrintArray(int[] collection)
{
    Console.Write("[");
    for (int index =0; index <collection.Length-1; index++)
    {
        System.Console.Write($"{collection[index]},");
    }
    System.Console.Write($"{collection[collection.Length-1]}");
    Console.Write("]");
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);