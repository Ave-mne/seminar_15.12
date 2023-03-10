// Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае если это невозможно, программа должна вывести сообщение пользователю.

int[,] matrix = CreateMatrixRndInt(5, 6, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
if (matrix.GetLength(0) == matrix.GetLength(1))
{
    int[,] newMatrix = ChangeRowColumnsMatrix(matrix);
    PrintMatrix(newMatrix);
}
else Console.WriteLine("Замена не возможна! Матрица не квадратная");

int[,] ChangeRowColumnsMatrix(int [,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newMatrix[i, j] = matrix[j, i];
        }
    }
    return newMatrix;
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