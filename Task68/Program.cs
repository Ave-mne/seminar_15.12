// Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int akkermanFunction = AkkermanFunction(m, n);
if (m > 0 && n > 0) Console.WriteLine($"{akkermanFunction}");
else Console.WriteLine("Введено ненатуральное число");

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return AkkermanFunction(m - 1, 1);
    else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}