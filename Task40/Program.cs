// Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами такой длины.


Console.Write("Введите число 1 ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2 ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3 ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool result = IsExistTriangle(number1, number2, number3);
Console.WriteLine(result ? "Трегольник может существовать" : "Трегольник не может существовать");

 bool IsExistTriangle(int num1, int num2, int num3)
 {
    int sum1 = num1 + num2;
    int sum2 = num1 + num3;
    int sum3 = num2 + num3;
    if (sum1 > num3 && sum2 > num2 && sum3 > num1) return true;
    else return false;
 }

