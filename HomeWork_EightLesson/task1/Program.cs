// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int n = WorkWithUser ("Введите число строк:  ");
int m = WorkWithUser ("Введите число столбцов:  ");
int[,] arrays = ArrayRandom(n,m);
PrintArray (SortToLower(arrays));



// Функция заполнения массива рандомно числами от 1 до 9
int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse (Console.ReadLine());
    return number;
}

int [,] ArrayRandom(int n, int m)
{
int [,] result= new int [n,m];
int temp = 1;
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = temp;
            temp+=2;
        }
    }
}
    return result;

}


// Функция сортировки элементов в строке двумерного массива, по убыванию
int [,] SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < arrays.GetLength(1); j++)
        {
            for (int k = 0; k < arrays.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
}

// Функция вывода двумерного массива
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