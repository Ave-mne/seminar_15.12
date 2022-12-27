// Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер ");
String number = Console.ReadLine();
if(number == "6" || number == "7")
{
    Console.WriteLine("Да");
}

else if(number == "1")
{
    Console.WriteLine("Нет");
}
else if(number == "2")
{
    Console.WriteLine("Нет");
}
else if(number == "3")
{
    Console.WriteLine("Нет");
}
else if(number == "4")
{
    Console.WriteLine("Нет");
}
else if(number == "5")
{
    Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Такого дня нет");
}