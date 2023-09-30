// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int n = WorkWithUser ("Введите число строк:  ");
int m = WorkWithUser ("Введите число столбцов:  ");
Console.WriteLine();


if (n == m)
{
int minValue = WorkWithUser ("Введите минимальное значение массива:  ");
int maxValue = WorkWithUser ("Введите максимальное значение массива:  ");
int[,] arrays = EnterArray(n,m, minValue, maxValue);
Console.WriteLine();
Console.WriteLine ("Это наш массив");
Console.WriteLine();
PrintArray(arrays);
Console.WriteLine();

PrintMyArray (SumRow(arrays));
Console.WriteLine();
MinSumRow(SumRow(arrays));
}
else
{
    Console.Write("Количество строк и столбцов должно быть одинаково!");
    Console.Write("\n Например: если ты вводишь количество строк = 2, то и количество столбцов тоже должны быть равны 2");
}



// Ввод переменных
int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse (Console.ReadLine());
    return number;
}




// ввод стандартного масива
int [,] EnterArray(int n, int m, int minValue, int maxValue)
{
int [,] result= new int [n,m];
Random rand = new Random();
{
   for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i,j] = rand.Next(minValue, maxValue);
        }
    }
}
    return result;
    
}


// Считаем сумму элементов каждой строки и выводим их в качестве одномерного массива.

int [] SumRow (int[,] matrix)
{
int  sum = 0;
int [] result = new int [matrix.GetLength(1)];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum  += matrix[i,j];
        result[i] = sum;
    }
}
return result;
}

void MinSumRow ( int [] result)
{
    Console.Write($"Наименьшая сумма элементов в строке = {result.Min()}");
}

// Выводим значения суммы каждой строки
void PrintMyArray(int [] my_array)
{
    for (int i=0; i<my_array.Length; i++)
    {
        Console.WriteLine($"Сумма элементов строки {i+1} = {my_array[i]} ");
    }
}


//  выводим наш стандартный думаерный массив
void PrintArray(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}