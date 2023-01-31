// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц

int[,] matrix1 = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateMatrixRndInt(4, 2, 1, 9);
PrintMatrix(matrix2);
Console.WriteLine();
int[,] matrix3 = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    MultiplyMatrix(matrix1, matrix2, matrix3);
    Console.WriteLine($"Произведение первой и второй матриц:");
    PrintMatrix(matrix3);
}
else Console.WriteLine("Число столбцов первой матрицы не равно числу строк второй. Умножать нельзя!!!");




void MultiplyMatrix(int[,] matrix1, int[,] matrix2, int[,] matrix3)
{
  for (int i = 0; i < matrix3.GetLength(0); i++)
  {
    for (int j = 0; j < matrix3.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        sum = matrix1[i,j] * matrix2[i,j];
      }
      matrix3[i,j] = sum;
    }
  }
}


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows,columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max +1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5}");
            else Console.Write($"{matrix[i, j], 5}  ");
        }
        Console.WriteLine("]");
    }
}