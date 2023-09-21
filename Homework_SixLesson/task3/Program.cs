// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Write ("Введи нижнюю границу массива:  ");
int minValue = int.Parse (Console.ReadLine());
Console.Write ("Введи верхнюю границу массива:  ");
int maxValue = int.Parse (Console.ReadLine());
Console.Write("Введи количество элементов массива:  ");
int QuantityElements = int.Parse(Console.ReadLine());

double [] my_array = new double [QuantityElements];
Random rand = new Random ();
// Ввод массива:
for (int i = 0; i < my_array.Length; i++)
{
    my_array[i]=rand.NextDouble();
}

// Вывод массива:
        for (int i = 0; i < my_array.Length; i++)
        {
            my_array[rand.Next(my_array.Length)] = rand.NextDouble() * (maxValue - minValue) + minValue;
            
        }
        
      Console.Write($"Вывод массива: {string.Join("; ", my_array.Select(x => x.ToString("F2")))}"); 
        
double max = my_array[0];
double min = my_array[0];

for (int i = 0; i < my_array.Length; i++)
{
    if (my_array[i] > max)
        max = my_array[i];
    if (my_array[i] < min)
        min = my_array[i];
}

double diff = max - min;

Console.Write($"\nМинимальный Элемент: {min:F2}");
Console.Write($"\nМаксимальный Элемент:  {max:F2}");
Console.WriteLine($"\nРазница между максимальным и минимальным элементами: {diff:F2}");