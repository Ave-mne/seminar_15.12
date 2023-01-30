// Задайте двумерный массив из челых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.

int[,] matrix = CreateMatrixRndInt(5, 5, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
int[] indexMinVal = IndexMInVal(matrix);
PrintArray(indexMinVal);
int[,] removeCrossedRowColumn = RemoveCrossedRowColumn(matrix, indexMinVal[0], indexMinVal[1]);
PrintMatrix(removeCrossedRowColumn);

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

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

int[] IndexMInVal(int[,] matrix)
{
    int min = matrix[0,0];
    int indexRow = 0;
    int indexColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < min)
            {
                min = matrix[i,j];
                indexRow = i;
                indexColumn = j;
            } 
        }
    }
    return new int[] {indexRow, indexColumn, min};
}

int[,] RemoveCrossedRowColumn(int[,] matrix, int removeRow, int removeColumn)
{
    int m = 0;
    int n = 0;
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if(i == removeRow) m++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if(j == removeColumn) n++;
            newMatrix[i,j] = matrix[m,n];
            n++;
        }
        m++;
        n = 0;
    }
    return newMatrix;
}