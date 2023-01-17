// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = CreateArrayRndDouble(5, 0.1 , 99.9);
PrintArrayDouble(array);
double getMinNumber = GetMinNumber(array);
double getMaxNumber = GetMaxNumber(array);
double difference = getMaxNumber - getMinNumber;
Console.WriteLine($"Разница между максимальным и минимальным значениями элементов массива = {Math.Round(difference, 1)}");


double[] CreateArrayRndDouble(int size, double min, double max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * ( max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

double GetMinNumber(double[] arr)
{
    double minNumb = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minNumb) minNumb = arr[i];
    }
    return minNumb;
}

double GetMaxNumber(double[] arr)
{
    double maxNumb = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxNumb) maxNumb = arr[i];
    }
    return maxNumb;
}
