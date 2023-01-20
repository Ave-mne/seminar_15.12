// Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь.
// 0,7,8,-2,-2,-> 2


Console.Write("Уточните сколько чисел вы хотите ввести? ");
int quantity = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayFromConsole(quantity);
PrintArray(array);
int positiveNumber = FindPositiveNumbers(array);
Console.Write($"Колличество положительных чисел = {positiveNumber}");

int[] CreateArrayFromConsole(int size)
{
    int [] arr = new int[size];
    for (int i = 0; i < size; i++) 
    {
        Console.WriteLine("Введите число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine()) ;
    }
    return arr;
}

int FindPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count++;
    }
    return count;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine();
}