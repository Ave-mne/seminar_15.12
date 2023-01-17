// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов стоящих на нечетных позициях.
// [3,7,23,12] -> 19
// [-4,-6,89,6] -> 0


int[] array = CreateArrayRndInt(4,-9,9);
PrintArray(array);
int getSumOddElem = GetSumOddElem(array);
Console.WriteLine($"Сумма нечетных элементов = {getSumOddElem}");

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max +1);
    }
    return arr;
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

int GetSumOddElem(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}
