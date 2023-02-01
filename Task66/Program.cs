//  Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > 0 && n > 0)
{
    if (m < n) Console.WriteLine(SumRec(m, n));
    if (m > n) Console.WriteLine(SumRec(n, m));
}
else Console.WriteLine("Ошибка!!! Введено не натуральное число");

int SumRec(int m, int n)
{
    if (m == n) return m;
    else return m + SumRec(m + 1, n);
}

