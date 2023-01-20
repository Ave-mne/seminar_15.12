// Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь.
// 0,7,8,-2,-2,-> 2


Console.Write("Уточните сколько чисел вы хотите ввести? ");
int quant = Convert.ToInt32(Console.ReadLine());
int[] array = new int[quant];

for (int i = 0; i < quant; i++) 
{
    Console.Write("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
    
PrintArray(array);
int positiveNumber = FindPositiveNumbers(array);
Console.Write($"Колличество положительных чисел = {positiveNumber}");


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