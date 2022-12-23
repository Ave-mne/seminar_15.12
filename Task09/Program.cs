//  Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8



int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}:");

int firstDijit = number / 10;
int secondDijit = number % 10;
if(firstDijit > secondDijit) Console.WriteLine($"Наибольшая цифра числа => {firstDijit}");
else Console.WriteLine($"Наибольшая цифра числа => {secondDijit}");