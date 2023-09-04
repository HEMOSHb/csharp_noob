// Задача №1 Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число 
// квадратом второго.
// a=25, b=5 -> да
// a=2, b=10 -> нет
// a=9, b=-3 -> да
// a=-3, b=9 -> нет

// Задача №3 Напишите программ, которая будет выдавать название дня недели
// по заданному номеру
// 3->Среда
// 5->Пятница

// Console.Write("Введите первое число: ");
// int a= int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int b= int.Parse(Console.ReadLine()!);

// if (a == (b*b))
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");    
// } 

// Console.WriteLine("Введите номер дня недели: ");
// string num = Console.ReadLine();
// switch (num)
// {
// case "1":
// Console.WriteLine("ПН");
// break;
// case "2":
// Console.WriteLine("ВТ");
// break;
// case "3":
// Console.WriteLine("СР");
// break;
// case "4":
// Console.WriteLine("ЧТ");
// break;
// case "5":
// Console.WriteLine("ПТ");
// break;
// case "6":
// Console.WriteLine("СБ");
// break;
// case "7":
// Console.WriteLine("ВС");
// break;
// default:
// Console.WriteLine("Нет такого дня недели");
// break;
// }

// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа 
// в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру 
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

// Console.WriteLine("Введите число = ");
// int number = int.Parse(Console.ReadLine());
// for (int firstNumber=-number; firstNumber <= number; firstNumber++) 
// {
//     Console.WriteLine(firstNumber);
// }

Строчный вариант

// Console.Write("Введите число: ");
// string number = Console.ReadLine();
// int len = number.Length;
// if (len == 3)
// {
//     Console.WriteLine(number[2]);
// }
// else
// {
//     Console.WriteLine("Вы ввели не трехзначное число");
// }

Второй вариант

// class Program
// {
// static void Main(string[] args)
// {
// Console.WriteLine("Введите трехзначное число:");
// int number = Convert.ToInt32(Console.ReadLine());

// int lastDigit = number % 10;
// Console.WriteLine("Последняя цифра числа: " + lastDigit);
// }
// }