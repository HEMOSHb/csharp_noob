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

int returnMethod (string message)
{
    Console.Write(message);
    int quantity = int.Parse(Console.ReadLine());
    return quantity;
}
int X=returnMethod("Введите точку X = ");
int Y=returnMethod("Введите точку Y = ");
if (X>0 && Y>0)
{
    Console.Write("I Четверть");
}
 else if (X<0 && Y>0)
    {
        Console.Write("II Четверть");
    }
    else if (X<0 && Y<0)
    {
        Console.Write("III Четверть");
    }
    else if (X>0 && Y<0)
    {
        Console.Write("IV Четверть");
    }
    else
    {
        Console.Write("Ошибка")
    }
}
