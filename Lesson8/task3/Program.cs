// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

// 25 мин
// Набор данных 
// { 1, 9, 9, 0, 2, 8, 0, 9 } 

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// Частотный массив:

// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза


// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
// 25 мин
// Набор данных Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 } 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

int[,] matrix = GetArray(3, 4, 1, 10);
PrintArray(matrix);
Console.WriteLine();
int[] array = CreateArray(matrix);
Print(array);
Console.WriteLine();
SortArray(array);
CountElement(array);

// Ввод массива
int[,] GetArray(int row, int column, int minValue, int maxValue)
{
    int[,] res = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            res[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return res;
}

// Вывод массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

// Вводим счетчик для подсчета элементов
int[] CreateArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count] = matrix[i, j];
            count++;
        }
    }
    return array;
}

// Вывод массива
void Print(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine("]");
}


// Упорядочиваем массив методом пузырька
void SortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1 - i; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }

    }
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}


// Считаем и выводим какое количество раз повторяется один и тот же элемент матрицы 
void CountElement(int[] array)
{
    int findElement = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] == findElement) count++;
        else
        {
            System.Console.WriteLine($"{findElement} встречается {count} раз");
            findElement = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{findElement} встречается {count} раз");
}