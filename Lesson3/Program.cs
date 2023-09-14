// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// Мой вариант с методом void
// Console.Write("Введите X = ");
// int X = int.Parse(Console.ReadLine());
// Console.Write("Введите Y = ");
// int Y = int.Parse(Console.ReadLine());
// void Quater (int X, int Y)
// {
//     if (X>0 && Y>0)
//     {
//         Console.Write("Точка находится в первой четверти плоскости");
//     }
//     else if (X<0 && Y>0)
//     {
//         Console.Write("Точка находится во второй четверти плоскости");
//     }
//     else if (X<0 && Y<0)
//     {
//         Console.Write("Точка находится в третьей четверти плоскости");
//     }
//     else
//     {
//         Console.Write("Точка находится в четвертой четверти плоскости");
//     }
// }
// Quater (X,Y);

// int returnMethod (string message)
// {
//     Console.Write(message);
//     int quantity = int.Parse(Console.ReadLine());
//     return quantity;
// }
// int X=returnMethod("Введите точку X = ");
// int Y=returnMethod("Введите точку Y = ");
// if (X>0 && Y>0)
// {
//     Console.Write("I Четверть");
// }
//  else if (X<0 && Y>0)
//     {
//         Console.Write("II Четверть");
//     }
//     else if (X<0 && Y<0)
//     {
//         Console.Write("III Четверть");
//     }
//     else if (X>0 && Y<0)
//     {
//         Console.Write("IV Четверть");
//     }
//     else
//     {
//         Console.Write("Ошибка");
//     }

// Создаем метод для решения данной задачи

// int returnMethod(string message)
// {
//     Console.Write(message);
//     int quantity = int.Parse(Console.ReadLine());
//     return quantity;
// }
//     string FindQuater(int X, int Y)
// {
//     string result = string.Empty;
//     if (X>0 && Y>0)
//     {
//         result = "I четверть";
//     }
//     else if (X<0 && Y>0)
//     {
//         result = "II четверть";
//     }
//     else if (X<0 && Y<0)
//     {
//         result = "III четверть";
//     }
//     else if (X>0 && Y<0)
//     {
//         result = "IV четверть";
//     }
//     else
//     {
//         result = "ошибка";
//     }
//     return result;
// }
// int X = returnMethod("Введите точку X = ");
// int Y = returnMethod("Введите точку Y = ");
// Console.Write(FindQuater(X,Y));

// Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

// int FindCoordinate_Method(string message)
// {
//     Console.WriteLine(message);
//     int quater = int.Parse(Console.ReadLine());
//     return quater;
// }
// String FindCoordinate(int quater)
// {
//     string result = string.Empty;
//     if (quater == 1)
//     {
//     result = "X>0; Y>0"; 
//     }
//     else if (quater == 2)
//     {
//     result = "X<0; Y>0";
//     }
//     else if (quater == 3)
//     {
//         result = "X<0; Y<0";
//     }
//     else if (quater == 4)
//     {
//         result = "X>0; Y<0";
//     }
//     else
//     {
//     result = "Ошибка";
//     }
//     return result;
// }
// int quater = FindCoordinate_Method("Какая четверть?");
// Console.Write(FindCoordinate(quater));

// Задача 21: Напишите программу, которая
// // принимает на вход координаты двух точек и
// // находит расстояние между ними в 2D
// // пространстве.
// // A (3,6); B (2,1) -> 5,09
// // A (7,-5); B (1,-1) -> 7,21

// Метод без массива
static bool IsPalindrome(int number){
        if (number < 10000 || number >= 100000){
            Console.WriteLine("Число не пятизначное");
            return false;

int DistanceBetweenPoints(int Length)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
double Length(double x1, double x2, double x3, double y1, double y2, double y3)
{
    double Length = Math.Sqrt((x1-y1)*(x1-y1)+(x2-y2)*(x2-y2)+(x3-y3)*(x3-y3));
    return Length;
}
double x1 = DistanceBetweenPoints("Точка А, координата X1 = ");
double x2 = DistanceBetweenPoints("Точка А, координата X2 = ");
double x3 = DistanceBetweenPoints("Точка A, координата X3 = ");
double y1 = DistanceBetweenPoints("Точка B, координата Y1 = ");
double y2 = DistanceBetweenPoints("Точка B, координата Y2 = ");
double y3 = DistanceBetweenPoints("Точка B, координата Y3 = ");

Console.Write(Length(x1,x2,x3,y1,y2,y3));

// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// int num = Find_lentgh_btw_2_points("Введите число = ");
// int[] mass = square(num);
// Printmassive(mass);

// int Find_lentgh_btw_2_points(string message) 
// { 
// Console.Write(message); 
// int number = int.Parse(Console.ReadLine()); 
// return number; 
// } 
// int[] square(int number) 
// { 
//     int[] massive = new int[number]; 
//     for (int i=0; i<number; i++) 
//     { 
//         massive[i] = (i+1) * (i + 1); 
//     } 
//     return massive;
// } 
// void Printmassive(int[] array)
// {
//     for (int i = 0; i<array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

