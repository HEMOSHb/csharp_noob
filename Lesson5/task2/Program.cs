﻿// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 12 10
Только для нечетного количества элементов массива

int [] arr = new int [] {1,2,3,4,5,6};
int [] newArr = Multiplication(arr);
Console.Write(string. Join("," , newArr));

int[] Multiplication(int[] array)
{
    int Size;
    if (array.Length % 2 == 0) Size = array.Length/2;
    else Size = array.Length/2 + 1;
    int [] newArray = new int [Size];
    for (int i = 0; i<newArray.Length; i++)
    {
        if (i==newArray.Length - 1) newArray[i] = array[i];
        else newArray[i] = array[i]*array[array.Length - i - 1];
    }
    return newArray;
}

Универсальный метод для четного и нечетного количества элементов массива

// int[] arr = new int[] {1, 2, 3, 4, 5};
// int[] newArr = Multiplication(arr);
// Console.WriteLine(string.Join(",", newArr));

// int[] Multiplication(int[] array)
// {
//     int size;
//     if(array.Length % 2 == 0) size = array.Length/2;
//     else size = array.Length /2 + 1;
//     int[] newArray = new int[size];
//     for (int i = 0; i < newArray.Length; i++)
//     {
//         if(array.Length % 2 == 1 && i == newArray.Length - 1) newArray[i] = array[i];
//         else newArray[i] = array[i] * array[array.Length - i - 1];
//     }
//     return newArray;
// }