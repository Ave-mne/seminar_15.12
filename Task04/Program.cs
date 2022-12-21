//  Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел

Console.Write("Введите первое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if(max < numberB)
{
    max = numberB;
}
if(max < numberC)
{
    max = numberC;
}
Console.WriteLine($"Максимальное число = {max}");
