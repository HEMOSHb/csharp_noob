// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


int WorkwithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int [,] GetArray (int row, int column, int minValue, int maxValue)
{
    int [,] result = new int [row, column];

Random rand = new Random();
    for (int i = 0; i<row; i++)
    {
        for (int j = 0; j<column; j++)
        {
            result [i,j]=rand.Next(minValue,maxValue);
        }
    }
    return result;
}

// Вывод двумерного массива
// ЧТобы считать длину строки (...Get.Length(0), для столбца ....Get.Length(1))
void PrintArray(int[,] inArray)
{
   for (int i = 0; i<inArray.GetLength(0); i++)
    {
        for (int j = 0; j<inArray.GetLength(1); j++)
        {
         Console.Write($"{inArray[i,j]} ");   
        }
        Console.WriteLine();
    } 
}


// вводим строки
int rows = WorkwithUser("Введите количество строк:  ");
// вводим столбцы
int columns = WorkwithUser("Введите количество столбцов:  ");
// вводим максимальное и минимальное значение
int minValue = WorkwithUser("Введите нижнюю границу массива:  ");
int maxValue = WorkwithUser("Введите верхнюю границу массива:  ");
int[,] array = GetArray(rows, columns, 10, 100);
PrintArray(array);

//вводим вторым способом
Console.WriteLine();
int[,] array2 = GetArray(WorkwithUser("строка: "), WorkwithUser("столбец:"), -10, 10);
PrintArray(array2);
