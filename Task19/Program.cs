// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да


Console.Write("Введите пятизначное число: ");
string  number = Console.ReadLine();
int len = number.Length;
if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Палиндром");
    }

    else
    {
        Console.WriteLine("Непалиндром");
    }
}
else Console.WriteLine("Введено некорректное число!");