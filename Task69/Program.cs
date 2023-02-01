// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numB > 0)
{
    Console.WriteLine(PowerRec(numA, numB));
}
else Console.WriteLine("Ошибка ввода степени");

int PowerRec(int a, int b)
{
    if (b == 0) return 1;
    else return PowerRec(a, b - 1) * a;
}