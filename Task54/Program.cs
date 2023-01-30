// Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] matrix = CreateMatrixRndInt(5, 7, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
SortRowWise(matrix);
PrintMatrix(matrix);


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



void SortRowWise(int [,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k];

                    matrix[i, k] = matrix[i, k + 1];

                    matrix[i, k + 1] = temp;
                }
            }
        }
    }
}