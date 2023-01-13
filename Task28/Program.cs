// Напишите программу, которая принимает на вход число N
// и выдает произведение чисел от 1 до N

// 4 -> 24
// 5 -> 120

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNamber = SumNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} равна {sumNamber}");

int SumNumbers(int num)
{
    int total = 1;
    for(int i = 1; i <= num; i++)
    {
        total *= i;
    }
    return total;
}