// / Задача 53: Задайте двумерный массив.
// Напишите программу, 
// которая поменяет местами первую и 
// последнюю строку массива.

int row = WorkWithUser("Введите количество строк: ");
int column = WorkWithUser("Введите количество столбцов: ");
int[,] matrix = GetArray(row, column, 1, 10);
PrintArray(matrix);
System.Console.WriteLine();
ReverseRow(matrix);
PrintArray(matrix);

// Ввод переменных

int WorkWithUser(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Ввод двумерного масива

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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Метод для разворота массива построчно

void ReverseRow(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }
}