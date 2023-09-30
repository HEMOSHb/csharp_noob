// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int PowerRecursive(int A, int B)
    {
        if (B == 0)
        {
            return 1;
        }
        else
        {
            return PowerRecursive(A, B - 1) * A;
        }
    }

    public static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        Console.WriteLine(PowerRecursive(A, B));
    }


