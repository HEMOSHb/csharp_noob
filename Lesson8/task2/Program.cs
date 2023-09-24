// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// Нужно разобраться
int[,] matrix = GetArray(3, 3, 1, 10);
PrintArray(matrix);
System.Console.WriteLine();
if(Change(matrix))
{
ReverseRouColumn(matrix);
}
else System.Console.WriteLine("Массив построить нельзя");
PrintArray(matrix);

// Ввод переменных
int WorkWithUser(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


// Количество строк и столбцов должны быть равны
bool Change(int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1)) return true;
    else return false;
}


// Меняем местами строки и столбцы
void ReverseRouColumn(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}

