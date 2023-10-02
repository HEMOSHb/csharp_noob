// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Не понимаю как этот метод оптимизировать =(

string ShowNumbers(int num)
{
    if(num == 1)
    {
     Console.Write("1"); 
    }
    else  
    {
        Console.Write(num + " ");
        ShowNumbers(num - 1);
    }
    return "1";
    
}




void PrintNumbers(int n)
{
if (n == 1) 
{
    Console.Write(1 +" ");
    return;
}

else
{
Console.Write(n + " ");
PrintNumbers(n - 1);
}
}
ShowNumbers(6);
Console.WriteLine();
PrintNumbers(5);
