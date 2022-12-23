// Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numb = number;
while(number > 1000)
{
   number = number / 10;
}

int thirdNumber = ThirdNumber(number);
Console.WriteLine($"Третья цифра числа {numb} => {thirdNumber}");

if(number < 100)
{
    Console.WriteLine($"В числе {numb} нет третьей цифры ");
}

int ThirdNumber(int num)
{
    return num % 10;
}