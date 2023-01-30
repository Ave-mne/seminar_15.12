// Задайте двумерный массив.
// напишите программу, которая поменяет местами первую и поледнюю строку массива.

int[,] matrix = CreateMatrixRndInt(5, 5, 1, 9);
PrintMatrix(matrix);
ChangeFirstAndLastRows(matrix);
Console.WriteLine();
PrintMatrix(matrix);


void ChangeFirstAndLastRows(int[,] matr)
{
    int firstRow = 0;
    int lastRow = matr.GetLength(0) -1;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int temp = matr[firstRow, i];
        matr[firstRow, i] = matr[lastRow, i];
        matr[lastRow, i] = temp;
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