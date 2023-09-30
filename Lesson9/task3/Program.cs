// Рекурсивным методом вывести числа фибоначчи

int n = 10;

Console.WriteLine("числа фибоначчи:");

for (int i = 0; i < n; i++)
{
    Console.WriteLine(Fibonacci(i));
}

int Fibonacci(int num)
{
    if (num <= 1) return num;
    else
        return Fibonacci(num - 1) + Fibonacci(num - 2);
}