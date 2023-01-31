// Сформируйте трехмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента

int[,,] matrix3D = Create3DMatrixRndInt(3, 3, 2);
Print3DMatrix(matrix3D);
Console.WriteLine();


for (int i = 0; i  <matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j  <matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k  <matrix3D.GetLength(2); k++)
                {
                    Console.WriteLine($"[{i},{j},{k}] - {matrix3D[i,j,k]}");
                }
        }
            Console.WriteLine();
    }


int[,,] Create3DMatrixRndInt(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows,columns,depth];
    int num = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = num;
                num++;
            }
            
        }
    }
    return matrix;
}

void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, k], 5}");
                else Console.Write($"{matrix[i, j, k], 5}  ");
            }
            
            
        }
        Console.WriteLine("]");
    }
}