// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


int sumofDigit(int num)
{
    if (num == 0) return num;
    else return num % 10 + sumofDigit(num / 10);
}
int res = sumofDigit (453);
Console.WriteLine(res);

