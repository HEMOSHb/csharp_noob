/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */



int WorkWithUser (string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// Ввод массива

int [] Array(int Quantity_elements)
{
int [] result = new int [Quantity_elements];

for (int i=0; i<result.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i} = ");
    result[i]=int.Parse(Console.ReadLine());
    
}
return result;
}

//считаем сколько элементов массива > 0

void CountEllements (int [] my_array)
{
    int count = 0;
    for (int i = 0; i < my_array.Length; i++)
    {
        if (my_array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine(count);
}

// Вывод массива
void PrintArray(int [] inArray)
{
    for (int i = 0; i<inArray.Length; i++)
    {
        Console.Write($"{inArray[i]}  ");
    }
}

// Вводим количество элементов массива
int Quantity_elements = WorkWithUser ("Введите количество элементов массива:  ");
// Выводим массив
int [] array = Array(Quantity_elements);
PrintArray(array);
// Выводим количество элементов массива
Console.Write("\nКоличество элементов массива > 0 = ");
CountEllements(array);


