// Найдите произведение пар чисел в одномерном массиве.
// Парой считается первый и последний элемент, второй и предпослений и т.д.
// Результат запишите в новом массиве
// [1,2,3,4,5] -> 5 8 3
// [6,7,3,6] -> 36 21

int[] array = CreateArrayRndInt(5, 1, 10);
PrintArray(array);
int[] resArray = MultiplayElements(array);
PrintArray(resArray);


int[] MultiplayElements( int [] arr)
{
    int size = arr.Length /2;
    if (arr.Length % 2 == 1) size += 1;
    int [] resArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        if (i != arr.Length - 1 - i)
        resArr[i] = arr[i] * arr[arr.Length - 1 - i];
        else resArr[i] = arr[i];
    }
    return resArr;
}

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
