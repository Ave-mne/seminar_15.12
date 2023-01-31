// Заполните спирально массив 4 на 4

int[,] matrix = CreateMatrixRndInt(4, 4);
PrintMatrix(matrix);
Console.WriteLine();
int[,] spiralMAtrix = FillArraySpiral(matrix);
PrintMatrix(spiralMAtrix);


int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows,columns];
    int num = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
                matrix[i, j] = num;
                num++;
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

int[,] FillArraySpiral(int[,] matrix)
{
    int count = 1, i = 0, j = 0;
    while (count <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = count;
        count++;
        if (i <= j + 1 && i + j < matrix.GetLength(0)-1) j++;
        
        else if (i < j && i + j >= matrix.GetLength(0)-1) i++;

        else if (i >= j && i + j > matrix.GetLength(1)-1) j--;
        else i--;

    }
    return matrix;
}