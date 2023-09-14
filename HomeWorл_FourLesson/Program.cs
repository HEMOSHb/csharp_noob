// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int WorkWithUser(string message)
// {
//     Console.Write(message);
//     int number=int.Parse(Console.ReadLine());
//     return number;
// }

// int Chislo_v_stepeni (int number_A, int number_B)
// {

// int Rank = 1;
// for (int i=1; i<=number_B; i++)
// {
//     Rank=Rank*number_A;
// }
// return Rank;
// }


// int number_A = WorkWithUser("Введите число которое нужно возвести в степень: ");
// int number_B = WorkWithUser("Введите степень: ");

// Console.Write(Chislo_v_stepeni(number_A, number_B));

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int WorkWithUser(string message)
// {
//     Console.Write(message);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }

// int FindSum(int number)
// {
    

//    return sum;
// }
// int number = WorkWithUser("Сумма = ");
// Console.Write(FindSum(number));

// Console.Write("Введите  ");
// int A = int.Parse(Console.ReadLine());
// int Res=A%10;
// Console.Write(Res);

// Возвратным методом у мкеня не получилось =(

// void FindSum (int i)
// {
// int sum = 0;

// while (i > 0)
// {
// int num = i % 10;
// i = i / 10;
// sum = sum + num;
// }
// }
// int i = WorkWithUser("Введите число: ");
// Console.Write(i);

// Решаем в лоб.

// Console.WriteLine("введите число");
// int i = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while (i > 0)
// {
// int num = i % 10;
// i = i / 10;
// sum = sum + num;
// }
// Console.WriteLine("сумма всех цифр в числе равна: " + sum);
