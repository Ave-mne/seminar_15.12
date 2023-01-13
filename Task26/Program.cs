// Напишите программу, которая принимает на вход число и 
// выдает количество цифр в числе.
// 456 -> 3
// 78 -> 2.
// 89126 -> 5


Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int countNumber = CountNumber(number);

if (number == 0)
{
    Console.WriteLine($"Количество чисел в числе {number} равно 1");
}
else
{
    Console.WriteLine($"Количество чисел в числе {number} равно {countNumber}");
}


int CountNumber(int num)
{
    int count = 0;
    while (num != 0)
    {
        num /= 10;
        count += 1;
    }
    return count;
}