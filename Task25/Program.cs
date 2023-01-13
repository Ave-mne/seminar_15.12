// Напишите цикл, который принимает на вход два числа(А и B)
// и возводит число А в натуральную степень B.
// 3, 5 -> 243
// 2, 4 -> 16

Console.Write("Введите число A ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB > 0)
{
    int degreeNumber = DegreeNumber(numberA, numberB);
    Console.WriteLine($"Число {numberA} в степени числа {numberB} равно {degreeNumber}");
}
else
{
      Console.WriteLine($"Число B '{numberB}' не является натуральным");
}


int DegreeNumber(int numA, int numB)
{
    int degree = Convert.ToInt32(Math.Pow(numA, numB));
    return degree;
}