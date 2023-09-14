// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А
// 7->28
// 4->10
// 8->36

// int WorkWithUser (string message)
// {
//     Console.Write(message);
//     int number = int.Parse(Console.ReadLine());
//     return number;

// }

// int FindSum(int number)
// {
//     int Sum = 0;
//     for (int i = 1; i<=number; i++)
// {
//     Sum = Sum + i;
// }
// return Sum;
// }

// int num = WorkWithUser("Введите число A: ");
// Console.WriteLine(FindSum(num));

// Метод Void
// int WorkWithUser (string message)
// {
//     Console.Write(message);
//     int number = int.Parse(Console.ReadLine());
//     return number;

// }
// void FindSum(int number)
// {
//     int Sum = 0;
//     for (int i = 1; i<=number; i++)
// {
//     Sum = Sum + i;
// }
// Console.Write(Sum);
// }

// int num = WorkWithUser("Введите число A: ");
// FindSum(num);


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int WorkWithUser(string message)
{
    Console.Write(message);
    int number=int.Parse(Console.ReadLine());
    return number;
}

int Chislo_v_stepeni (int number_A, int number_B)
{

int Rank = 1;
for (int i=1; i<=number_B; i++)
{
    Rank=Rank*number_A;
}
return Rank;
}


int number_A = WorkWithUser("Введите число которое нужно возвести в степень: ");
int number_B = WorkWithUser("Введите степень: ");

Console.Write(Chislo_v_stepeni(number_A, number_B));