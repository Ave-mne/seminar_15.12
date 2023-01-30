// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемнт входных данных.

int[,] matrix = CreateMatrixRndInt(5, 6, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
int[] array = MatrixToArray(matrix);
PrintArray(array);
Array.Sort(array);
PrintArray(array);
UniqElemQantity(array);

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

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)*matrix.GetLength(1)];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i,j];
            k++;
        }
    }
    return array;
}

void UniqElemQantity(int [] arr)
{
    int count = 1;
    int currentElement = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == currentElement) count++;
        else
        {
            Console.WriteLine($"{currentElement} -> {count}");
            currentElement = arr[i];
            count = 1;

        }
    }
    Console.WriteLine($"{currentElement} -> {count}");
}