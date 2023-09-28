// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GetArray(int row, int column)
{
    int[,] result = new int[row, column];
    Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = i+j;
        }
    }
    return result;
}

// Создаем метод
void SquareArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                inArray [i,j] = inArray[i,j] * inArray[i,j];
            }
        }
    }
    
}

void PrintArray(int[,] inArray)
{
    Console.Write ($"The number in [{x}, {y}] is {result}")
}

int rows = WorkWithUser("Введите количество строк: ");
int columns = WorkWithUser("Введите количество столбцов: ");
int[,] array = GetArray(rows, columns);
Console.Write("Начальный массив:  ");
PrintArray(array);
Console.Write("Второй массив:  ");
SquareArray(array);
PrintArray(array);