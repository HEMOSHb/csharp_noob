

using System.Xml.XPath;

void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }

    }
  
    int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
    int [,] result = new int [n,m];
    
    Random rand = new Random();
    int current = 1;
    for (int i=0; i<n; i++)
    {
        for (int j=0; j<m; j++)
        {
        result [i,j] = current;
        current += k;
        }
    }

    return result;

    }
  
    int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
{  
      // Введите свое решение ниже

 int[] result = new int [] {0,0};
  if (matrix.GetLength(0) > rowPosition && matrix.GetLength(1) > columnPosition)
{
  
    result = new  int [] {matrix[rowPosition, columnPosition], 0};
    
}
return result;

}

 

    void PrintCheckIfError (int[] results, int X, int Y)
{
      // Введите свое решение ниже

    for (int i=0; i<results.Length; i++)
{
  if (results[0] > 0)
  {
    Console.Write($"{results[i]} ","");
  }
    else
    {
       Console.Write ("There is no such index");
    }

}


}

    

    // Не удаляйте и не меняйте метод Main! 
    

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(3, 3, 2);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, 3, 3), 1, 2);


      