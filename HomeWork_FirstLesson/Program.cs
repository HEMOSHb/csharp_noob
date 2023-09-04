// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число: ");
// int FirstNumber = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int SecondNumber = int.Parse(Console.ReadLine());
// if (FirstNumber > SecondNumber)
// {
//     Console.WriteLine("Первое число = max");
// }
// else
// {
//     Console.WriteLine("Второе число = max");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Первое число (a) = ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Второе число (b) = ");
// int b = int.Parse(Console.ReadLine());
// Console.Write("Третье число (c) = ");
// int c = int.Parse(Console.ReadLine());
// if (a>b && a>c)
// {
//     Console.WriteLine ("a=max");
// }
// else if (b>c && b>a)
// {
//     Console.WriteLine ("b=max");
// }
// else if (c>a && c>b)
// {
//     Console.WriteLine ("c=max");
// }

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число");
// int Number = int.Parse(Console.ReadLine());
// if (Number % 2 == 0)
// {
//     Console.WriteLine("Четное");
// }
// else
// {
// Console.WriteLine("Нечетное");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа 
//от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Введите число N = ");
// int N = int.Parse(Console.ReadLine());
// for ( int i = 1; i <= N; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.WriteLine(i);
//     }
// }