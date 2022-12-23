// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
int firstDijit = number / 100;
int thirdDijit = number % 10;

int result = firstDijit*10 + thirdDijit;
Console.WriteLine($" Результат из {number} => {result}");