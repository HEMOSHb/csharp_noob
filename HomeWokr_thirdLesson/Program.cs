// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.


// using System;

// public class Answer
// {
//     static bool IsPalindrome(int number){
//         if (number < 10000 || number >= 100000){
//             Console.WriteLine("Число не пятизначное");
//             return false;
//         }

//         int reverse = 0;
//         int temp = number;
//         while (temp > 0){
//             reverse = reverse * 10 + temp % 10;
//             temp /= 10;
//         }
//         return reverse == number;
//     }

//       static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//             number = 645464;
//         }

//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
//     }
// }

// Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход координаты двух точек 
// pointA и pointB в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.

// Мой вариант решения:

// using System;

// public class Answer
// {
//       // Введите свое решение ниже
// private static double DistanceBetweenPoints(double x1, double x2, double x3, double y1, double y2, double y3)
// {
//    double result = Math.Sqrt((x1-y1)*(x1-y1)+(x2-y2)*(x2-y2)+(x3-y3)*(x3-y3)); 
//     return result;
// }                      


//   // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args) 
//     {
//         int x1, x2, x3, y1, y2, y3;

//         if (args.Length >= 6) {
//             x1 = int.Parse(args[0]);
//             x2 = int.Parse(args[1]);
//             x3 = int.Parse(args[2]);
//             y1 = int.Parse(args[3]);
//             y2 = int.Parse(args[4]);
//             y3 = int.Parse(args[5]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             x1 = 3;
//             x2 = 6;
//             x3 = 8;
//             y1 = 2;
//             y2 = 1;
//             y3 = -7;
//         }

//         // Не удаляйте строки ниже
//         double res = DistanceBetweenPoints(x1, x2, x3, y1, y2, y3);
//         Console.WriteLine($"{res:F2}");
//     }
// }

// Вариант решения с функцией вовзедения в степень Math.Pow.
// private static double Length(int[] pointA, int[] pointB)
//     {
//       // Введите свое решение ниже
//         double distance = Math.Sqrt(Math.Pow((pointA[0] - pointB[0]), 2) + 
//                                     Math.Pow((pointA[1] - pointB[1]), 2) + 
//                                     Math.Pow((pointA[2] - pointB[2]), 2));
//         return distance;

//     }

// Эталонный вариант решения:

// using System;

// public class Answer
// {
//     private static int Square(int number)
//     {
//         return number * number;
//     }

//     private static int SumSquare(int[] pointA, int[] pointB)
//     {
//         int sum = 0;
//         for (int i = 0; i < pointA.Length; i++)
//         {
//             sum += Square(pointA[i] - pointB[i]);
//         }
//         return sum;
//     }

//     private static double Length(int[] pointA, int[] pointB)
//     {
//         double result = Math.Sqrt(SumSquare(pointA, pointB));
//         return result;
//     }

//     public static void Main(string[] args) {
//         int x1, x2, x3, y1, y2, y3;

//         if (args.Length >= 6) {
//             x1 = int.Parse(args[0]);
//             x2 = int.Parse(args[1]);
//             x3 = int.Parse(args[2]);
//             y1 = int.Parse(args[3]);
//             y2 = int.Parse(args[4]);
//             y3 = int.Parse(args[5]);
//         } else {
//             x1 = 3;
//             x2 = 6;
//             x3 = 8;
//             y1 = 2;
//             y2 = 1;
//             y3 = -7;
//         }

//         double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
//         Console.WriteLine($"{result:F2}");
//     }
// }

// Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) и 
// выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.
// Мой вариант решения:
// int Cube = 0;
//           for (int i=1; i<=N; i++)
//           {
//               Cube = i*i*i;
//               Console.WriteLine(Cube);
//           }
// Эталонный вариант:
// using System;

// public class Answer
// {
//     static void ShowCube(int N)
//     {
//         for (int i = 1; i <= N; i++)
//         {
//             Console.WriteLine(Cube(i));
//         }
//     }

//     public static int Cube(int number)
//     {
//         return number * number * number;
//     }

//       static public void Main(string[] args) {
//         int N;

//         if (args.Length >= 1) {
//             N = int.Parse(args[0]);
//         } else {
//             N = 6;
//         }

//         ShowCube(N);
//     }
// }