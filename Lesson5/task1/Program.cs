int [] array = {-4,-8,8,2};
int[] reArray = new int [4];
for (int i = 0; i<array.Length; i++)
{
    
    reArray[i]=array[i] * -1;
    
}
Console.Write("Вывод массива [ ");
for (int i=0; i<array.Length; i++)
{
    Console.Write($"{array[i]} ","");
}
Console.Write("]");
Console.ReadLine();



// int[] array = {-4, -8, 8, 2};
// int[] resArray = new int[4];
// for (int i = 0; i < array.Length; i++)
// {
    
    
//     resArray[i] = array[i] * -1;
    
    
// }
// string resArray2 = String.Join(", ", resArray);
// Console.WriteLine(resArray2);