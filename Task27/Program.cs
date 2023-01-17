// Напишите программу, которая принимает на вход число и 
// выдает сумму цифр в числе
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumber = SumNumber(number);

if (number > 0)
{
    Console.WriteLine($"Сумма цифр числа {number} равна {sumNumber}");
}
else
{
    Console.WriteLine($"Число {number} не является натуральным!");
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