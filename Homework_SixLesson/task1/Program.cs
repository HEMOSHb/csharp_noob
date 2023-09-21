

Console.Write("Введите нижнюю границу массива:  ");
int minValue=int.Parse(Console.ReadLine());

Console.Write("Введите верхнюю границу массива:  ");
int maxValue=int.Parse(Console.ReadLine());

if (minValue>99 && maxValue<1000)
{
Console.Write("Напиши размер массива:  ");
int QuantityElements = int.Parse(Console.ReadLine());
int[] my_array = new int [QuantityElements];;
Random rand = new Random();
    for (int i = 0; i < my_array.Length; i++)
    {
        my_array[i] = rand.Next(minValue, maxValue);
    }
        Console.Write("Вывод массива со всеми элементами:   ");
for (int i=0; i<my_array.Length; i++)
{
    Console.Write(my_array[i] + " ");
 }

    Console.Write("\nВывод массива массива с четными элементами:   ");
for (int i=0; i<my_array.Length; i++)
{
    if (my_array[i]%2==0)
    {
    Console.Write(my_array[i] + " ");
    }
}


int evenCount = 0;

foreach (int num in my_array) 
{
    if (num % 2 == 0) {
        evenCount++;
    }
}

Console.WriteLine("\nКоличество четных элементов: " + evenCount);
}
else 
{
Console.Write("попробуй трехзначное число!!!");
}



