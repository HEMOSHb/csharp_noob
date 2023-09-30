// Задача 63: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


string ShowNumbers(int num)
{
    if(num == 1) return "1 ";
    else return  ShowNumbers(num - 1) + $"{num} ";
}

void Show(int number)
{
    if(number == 1) Console.Write(1 + " ");
    else 
    {
        Show(number - 1);
        Console.Write(number + " ");
        
    }
}

Console.WriteLine(ShowNumbers(5));
Show(6);


