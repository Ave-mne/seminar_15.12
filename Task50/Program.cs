// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого же элемента 
// или же указание, что такого элемента нет.


Console.Write("Введите строку интересующего элемента ");
int rowsI = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец интересующего элемента ");
int columnsJ = Convert.ToInt32(Console.ReadLine());
int[,] array2d = CreateMatrixRndInt(5, 4, 1, 9);
PrintMatrix(array2d);
if(rowsI <= array2d.GetLength(0) && columnsJ <= array2d.GetLength(1))
{
    Console.WriteLine($"Интересующий Вас элемент -> {array2d[rowsI -1, columnsJ -1]}"); 
} 
else Console.WriteLine($"В массиве отсутствует элемент с позициями -> ({rowsI}, {columnsJ}) "); 



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