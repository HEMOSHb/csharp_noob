int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// int WorkWithUser(string message)
// {
//     Console.Write(message);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }


int[]GerArray(int Size, int minValue, int maxValue)
{
int[] result = new int [Size];
Random rand = new Random();
for (int i=0; i<result[i]; i++)
{
    result[i]=rand.Next(minValue,maxValue+1);
}
return result;
}

// int[] GetArray(int length, int min, int max)
// {
//     int[] result = new int[length];
//     Random rand = new Random();
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = rand.Next(min, max + 1);
//     }
//     return result;
// }


void PrintArray(int[] arr)
{
    for (int i = 0; i<arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + " ");
//     }
// }

int Size=WorkWithUser("Введите размер массива: ");
int maxValue=WorkWithUser("Введите максимальное значение диапазон: ");
int minValue=WorkWithUser("Введите минимальное значение диапазона: ");


void GetSums(int [] inArray)
{
int PositiveSum=0;
int negativeSum=0;
foreach(int el in inArray)
{
if (el>0) PositiveSum += el;
else negativeSum += el;
}

// int[] GetSums(int[] inArray)
// {
//     int[] res = new int[2];
//     foreach (int el in inArray)
//     {
//         if (el > 0) res[0] += el;
//         else res[1] += el;
//     }
//     return res;
// }

Console.Write($"Сумма положительных чисел равна {PositiveSum}, сумма отрицательных числе равна {negativeSum}");
}
int[] array = GerArray(Size,minValue,maxValue);
PrintArray(array);
int sums = GetSums(array);

// int size = WorkWithUser("Введите размер массива: ");
// int minValue = WorkWithUser("Введите минимальное значение диапазона: ");
// int maxValue = WorkWithUser("Введите максимальное значение диапазона: ");
// int[] array = GetArray(size, minValue, maxValue);
// PrintArray(array);
// int[] sums = GetSums(array);
// Console.WriteLine($"Сумма положительных чисел равна {sums[0]}, сумма отрицательных {sums[1]}");







// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов 
// массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел
// равна 29, сумма отрицательных равна -20.
int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int[] GetArray(int length, int min, int max)
{
    int[] result = new int[length];
    Random rand = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rand.Next(min, max + 1);
    }
    return result;

}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
int[] GetSums(int[] inArray)
{
    int[] res = new int[2];
    foreach (int el in inArray)
    {
        if (el > 0) res[0] += el;
        else res[1] += el;
    }
    PrintArray(res);
    return res;


}


int size = WorkWithUser("Введите размер массива: ");
int minValue = WorkWithUser("Введите минимальное значение диапазона: ");
int maxValue = WorkWithUser("Введите максимальное значение диапазона: ");
int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);
Console.WriteLine();
int[] sums = GetSums(array);






//Console.WriteLine(string.Join(" ", array));