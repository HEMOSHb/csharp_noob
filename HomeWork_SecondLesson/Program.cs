// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.

// Console.Write("Введи трехзначное число число A = ");
// int A = int.Parse (Console.ReadLine());
// if (A >=100 && A <1000)
// {
//    int FirstDigit = (A % 100);
//    int ThirdDigit = (A % 10);
//    int SecondDigit = (FirstDigit / 10);
//     Console.Write($"Вторая цифра числа {A} является {SecondDigit}");
// }
// else
// {
//     Console.Write("Валера, ТЫ НОРМАЛЬНЫЙ!? ЭТО НЕ ТРЕХЗНАЧНОЕ ЧИСЛО! Попробуй ещё раз, пожалуйста =)");
// }

// Второй способ решения задачи №10 с помощью метода promt.
int Promt (string message)
{
    System.Console.Write(message);
    string value=Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int number = Promt("Введите трехзначное число > ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод");
    return;
}
Console.WriteLine($"Введенное число `{number}`");
int secondRank = number / 10% 10;
Console.WriteLine($"Вторая цифра `{secondRank}`");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Console.Write("Введи число А = ");
// int A = int.Parse(Console.ReadLine());
// if (A>99 && A<1000)
// {
//     int ThirdDigit = (A % 10);
//     Console.Write($"Третья цифра числа {A} является {ThirdDigit}");

// }
// else if (A>1000 && A<10000)
// {

// int ThirdDigit = ((A%100)/10);
//     Console.Write($"Третья цифра числа {A} является {ThirdDigit}");
// }
// else if (A>10000 && A<100000)
// {
//     int ThirdDigit = ((A%1000)/100);
//     Console.Write($"Третья цифра числа {A} является {ThirdDigit}");
// }
// else if (A>99999)
// {
//     Console.Write("Такое я ещё не умею =( ");
// }
// else
// {
//     Console.Write("У этого числа нет третьей цифры, попробуй еще ;-)");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите номер дня недели  A = ");
// int A = int.Parse(Console.ReadLine());
// if (A<6)
// {
//     Console.Write("К сожалению, это не выходной");
// }
// else if (A < 8)
// {
//     Console.Write("Ты угадал, это выходной");
// }
// else
// {
//     Console.Write("Друг, нет такого дня на неделе");
// }
