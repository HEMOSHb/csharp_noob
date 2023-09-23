// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double WorkWithUser (string message)
{
    Console.Write(message);
    double number = double.Parse(Console.ReadLine());
    return number;
}


double [] Massive (double b1, double k1, double b2, double k2)
{
    double [] massive = new double [2];
    massive[0]=(b2 - b1)/(k1 - k2);
    massive[1]=(k1 * massive[0] + b1);
    return massive;
}


double b1 = WorkWithUser("b1 = ");
double k1 = WorkWithUser("k1 = ");
double b2 = WorkWithUser("b2 = ");
double k2 = WorkWithUser("k2 = ");

double [] res = Massive(b1,k1,b2,k2);
 Console.WriteLine(string.Join(", ", res.Select(x => x.ToString("N1"))));


