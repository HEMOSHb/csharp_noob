// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Введите нижнюю границу массива:  ");
int minValue = int.Parse(Console.ReadLine());
Console.Write("Введите верхнюю границу массива:  ");
int maxValue = int.Parse(Console.ReadLine());
Console.Write ("Введите количество элементов массива:  ");
int QuantityElements = int.Parse(Console.ReadLine());

int [] my_array = new int [QuantityElements];
Random rand = new Random ();
// Ввод массива
for (int i = 0; i<my_array.Length; i++)
{
    my_array[i] = rand.Next (minValue,maxValue);
}
// Вывод массива
Console.Write ("Выводим массив:  ");
for (int i=0; i<my_array.Length; i++)
{
    Console.Write (my_array[i] + " ");
}

Console.Write("\nВыводим массив с эллементами, которые занимают нечетные позции:  ");
for (int i = 0; i<my_array.Length; i+=2)
{
    // Выводим элементы массива, которые занимают нечетные позиции
    
    
        Console.Write (my_array[i] + " ");
    
}
// Выводим сумму элементов массива, которые занимают нечетные позции.
int total = 0;
for (int i = 0; i<my_array.Length; i+=2)
{
    total += my_array[i];
}

 Console.WriteLine("\nСумма элементов массива,стоящих на нечетных позициях " + total);
