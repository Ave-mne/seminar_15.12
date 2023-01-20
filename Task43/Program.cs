// Напишите программу, которая найдет точку пересечения двух прямых,
// заданных уравнениями 'Y = K1 * X + B1, Y = K2 * X + B2;
// Значения B1, K1, B2, K2 задаются пользователем.
// B1 = 2, K1 = 5, B2 = 4, K2 = 9  -> (-0.5, -0.5)

Console.WriteLine("Введите значение 'B1' ");
double pointB1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение 'K1' ");
double pointK1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение 'B2' ");
double pointB2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение 'K2' ");
double pointK2 = Convert.ToInt32(Console.ReadLine());

double x = FindX(pointB1, pointK1, pointB2, pointK2);

Console.WriteLine($"Точка пересечения двух прямых: ({pointK1 * x + pointB1}; {pointK2 * x + pointB2})");

double FindX(double b1, double k1, double b2, double k2)
{
    x = (b2 -b1)/(k1-k2);
    return x;
}
