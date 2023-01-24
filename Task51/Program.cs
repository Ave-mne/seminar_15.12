﻿// Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали
// (с индексами(0,0),(1,1) и тд)

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);

PrintMatrix(array2d);
int sumDiagonalIndex = FindSumDiagonalIndex(array2d);
Console.WriteLine($"Сумма элементов, находящихся на главной диагонали = {sumDiagonalIndex}");

int FindSumDiagonalIndex(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == j) sum += matrix[i, j];
        }
    }
    return sum;
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5},");
            else Console.Write($"{matrix[i, j], 5}  ");
        }
        Console.WriteLine("]");
    }
}