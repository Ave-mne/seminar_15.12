// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
int lastFigure = number%10;
if(number >= 100 && number <= 999)
{
    Console.WriteLine($"Последняя цифра {lastFigure}");
}
else
{
    Console.WriteLine("Ошибка! Введено не трехзначное число");
}
