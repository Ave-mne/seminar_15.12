// Напишите программу, которая принимает на вход число(N) 
// и выдает таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if( number > 0)
{
    TableSquare(number);
}
else Console.Write("Введено не натуральное число");

 void TableSquare(int num)
 {
    int count = 1;
    while (count <= number)
    {
        Console.WriteLine($"{count, 4}{Math.Pow(count, 2),4}"); // выравномание по правой стороне
        count++;
    }

 }