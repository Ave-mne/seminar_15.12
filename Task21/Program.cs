// Напишите прогормамму, которая принимает на вход координаты двух точек 
// и находит растояние между ними в 3D пространстве.
// A(3,6, 8); B(2,1, -7) -> 15.84
// A(7,-5, 0); B(1,-1, 9) -> 11.53


Console.WriteLine("Введите координаты трех точек: ");
Console.Write("xA: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("yA: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("zA: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("xB: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("yB: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("zB: ");
int zb = Convert.ToInt32(Console.ReadLine());

double Ourdistance = Math.Round(Distance(xa, xb, ya, yb, za, zb), 2, MidpointRounding.ToZero);
Console.WriteLine($"Растояние между точками {xa}, {xb} и {ya}, {yb} и {za}, {zb}= {Ourdistance}");

double Distance(int x1, int x2, int y1 ,int y2, int z1, int z2)
{
    double distance = Math.Sqrt((Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2)+ + Math.Pow((z2-z1), 2))); 
    return distance;
}