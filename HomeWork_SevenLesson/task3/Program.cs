// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, PrintListAvr и FindAverageInColumns.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на опрделенное число. 
// Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, 
// удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

// Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает одномерный массив типа double. 
// Этот метод вычисляет среднее значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.

// Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns и выводит этот список на экран в формате 
// "The averages in columns are: x.x0 x.x0 x.x0 ...", где x.x0 - это значения средних значений столбцов, округленные до двух знаков после запятой, разделенные знаком табуляции.


using System.Collections.Concurrent;
using System.Globalization;

void PrintArray (int [,] matrix)
{
for (int i = 0; i<matrix.GetLength(0); i++)
{
    for (int j = 0; j<matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]}\t");
    }
    Console.WriteLine();
}
}



int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int [,] matrix = new int [n,m];
    int current = 1;
    for (int i = 0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            matrix [i,j] = current;
            current += k;
        }
    }
    return matrix;
}


void PrintListAvr(double[] list)
    {
        // Введите свое решение ниже
        Console.WriteLine("The averages in columns are: ");
        for (int i = 0; i < list.Length; i++)
            Console.Write(list[i].ToString("F2") + "\t");
    }




double [] FindAverageInColumns (int [,] matrix)
{
    int size = matrix.GetLength(1);
      double[] resultMatrix = new double[size];
      double result;      
    
      for(int i = 0; i < matrix.GetLength(1); i++)
      {
        double temp = 0.0;
        for(int j = 0; j < matrix.GetLength(0); j++)
        {
            // Перебираем элементы, temp = 0 и в цикле складывается со всеми элементами стольца матрицы.
            // далее эта сумма делится на количество элементов столбца.
          temp = matrix[j,i] + temp; 
        }
        // result = сумма / количество элементов столбца
        // выводим средние числа столбца в строку
        result = temp / matrix.GetLength(0);
        resultMatrix[i] = result;

      }
      return resultMatrix;

    }




        int[,] result = CreateIncreasingMatrix(3, 4, 2);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));