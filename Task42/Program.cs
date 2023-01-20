// Напишите программу, которая будет преобразовывать десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10
string res = ConverseDecToBin(13);
Console.WriteLine(res);

string ConverseDecToBin(int num)
{
    string result = string.Empty;
    while(num > 0)
    {
        result =  num % 2 + result; 
        num /=2;
    }
    return result;
}