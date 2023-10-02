// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System.Diagnostics.CodeAnalysis;

int EnterValue(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int PrintNumbers(int n,int m)
{
if (n > m) 
{
    return 0;   
}

else return m + PrintNumbers(n,m-1);

}

int n = EnterValue ("Введите n:  ");
int m = EnterValue ("Введите m:  ");
PrintNumbers(n,m);
Console.Write (PrintNumbers(n,m));