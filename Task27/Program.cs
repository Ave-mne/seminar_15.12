// Напишите программу, которая принимает на вход число и 
// выдает сумму цифр в числе
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumber = SumNumber(number);

if (number < 10)
{
    Console.WriteLine($"Сумма цифр равна {number}");
}
else
{
    Console.WriteLine($"Сумма цифр в числе {number} равна {sumNumber}");
}


int SumNumber(int num)
{
    int sum = 0;
    while (num != 0)
    {
        int i = num % 10;
        sum += i;
        num /= 10;
    }
    return sum;
}