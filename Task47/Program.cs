// Задайте двумерный массив размером m*n, 
// Заполненный случайными вещественными числами.

double[,] array2d = CreateMatrixRndDouble(3, 4, 1.0, 9.9);
PrintMatrix(array2d);


double[,] CreateMatrixRndDouble(int rows, int columns, double min, double max)
{
    double[,] matrix = new double[rows,columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double num  = rnd.NextDouble() * ( max - min) + min;
            matrix[i, j] = Math.Round(num, 1);
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5},");
            else Console.Write($"{matrix[i, j], 5}  ");
        }
        Console.WriteLine("]");
    }
}