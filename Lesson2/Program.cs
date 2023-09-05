// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);
// void DeleteSecondDigit(int number)
// {
//     int firstDigit = number / 100;
//     int thirdDigit = number %10;
//     int number1 = firstDigit*10 + thirdDigit;
//     System.Console.WriteLine(number1);
// }
// DeleteSecondDigit(number);


// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);

// DeleteSecondDigit(number);

// void DeleteSecondDigit(int number)
// {
//     int firstDigit = number / 100;
//     int thirdDigit = number %10;
//     int number1 = firstDigit*10 + thirdDigit;
//     System.Console.WriteLine(number1);
// }

// 12. Напишите программу, которая будет принимать
// на вход два числа и выводить, является ли второе
// число кратным первому. Если число 2 не кратно числу
// 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.Write("Введите число A = ");
// int A = int.Parse(Console.ReadLine());
// Console.Write("Введите число B = ");
// int B = int.Parse(Console.ReadLine());
// void Multiply(int A, int B)
// {
//     if (B % A == 0)
//     {
//         Console.Write("Кратно");
//     }
//     else
//     {
//         int remainder = B % A;
//         Console.Write($"Не кратно, остаток от деления = {remainder}");
//     }
// }
// Multiply(A,B);

// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// Console.Write("Введите число А = ");
// int A = int.Parse(Console.ReadLine());
// void Kpatno (int A)
// {
//     if (A%23 == 0 && A%7 ==0)
//     {

//     Console.Write("ДА");
       
//     }
// else
//     {
//         Console.Write("Неееееааа!");
//     }
// }
// Kpatno(A);