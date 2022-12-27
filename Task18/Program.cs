// Напишите программу, которая по задонному номеру четверти, 
// показывает диапозон возможных координат точек в этой четверти(Х и У)

Console.WriteLine("Введите номер четверти точки");

string quarter = Console.ReadLine();

string result = QuarterCoordinates(quarter);
Console.WriteLine(result);

string QuarterCoordinates(string number)
{
    if(number == "1") return "X > 0 и Y > 0";
    if(number == "2") return "X < 0 и Y > 0";
    if(number == "3") return "X < 0 и Y < 0";
    if(number == "4") return "X > 0 и Y < 0";
    return "Неверный номер четверти";
}