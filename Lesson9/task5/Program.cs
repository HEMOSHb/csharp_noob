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

   
        Console.Write("Введите A:  ");
        int A = int.Parse(Console.ReadLine());
        Console.Write ("Введите B:  ");
        int B = int.Parse(Console.ReadLine());
        Console.WriteLine(PowerRecursive(A, B));
    
// Второй вариант

// int Degree(int a, int b)
// {
//     if(b == 0) return 1;
//     else
//     {
//         return a * Degree(a, b - 1);
//     }
// }

// int res = Degree(2, 3);
// Console.WriteLine(res);