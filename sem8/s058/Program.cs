// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void CreateTwoDimArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {// 
      array[i, j] = new Random().Next(0, 9);
    }
  }
}

void ProductMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] newMatrix)
{
  for (int i = 0; i < newMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < newMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int n = 0; n < firstMartrix.GetLength(1); n++)
      {
        sum += firstMartrix[i,n] * secomdMartrix[n,j];
      }
      newMatrix[i,j] = sum;
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

int[,] firstMartrix = new int[2, 2];
CreateTwoDimArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
PrintArray(firstMartrix);

int[,] secomdMartrix = new int[2, 2];
CreateTwoDimArray(secomdMartrix);
Console.WriteLine($"Вторая матрица:");
PrintArray(secomdMartrix);

int[,] resultMatrix = new int[2,2];

ProductMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Результирующая:");
PrintArray(resultMatrix);