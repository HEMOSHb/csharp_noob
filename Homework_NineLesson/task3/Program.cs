int EnterValue(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int PrintNumbersAckerman(int m,int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return PrintNumbersAckerman(m - 1, 1);
    if (m > 0 && n > 0) return PrintNumbersAckerman(m - 1, PrintNumbersAckerman(m, n - 1));
    return PrintNumbersAckerman(m,n);
}
int m = EnterValue ("Введите m:  ");
int n = EnterValue ("Введите n:  ");

if (m < 0 || n<0)
{
    Console.Write("Числа m и n должны быть не отрицательными, попробуй еще раз!!!!");
}
else
{
Console.Write ($"m = {m}, n = {n} => A(m,n) = {PrintNumbersAckerman(m,n)}");
}