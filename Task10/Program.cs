//  Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number <1000)
{
    int secondDigit = (number / 10) % 10;
    Console.WriteLine($" Результат из {number} => {secondDigit}");
}
else
{
    Console.WriteLine("Неправильное число");
}