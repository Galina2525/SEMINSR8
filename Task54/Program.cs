// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки по убыванию
Console.WriteLine("Enter m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n");
int n = Convert.ToInt32(Console.ReadLine());

int[,] ourMatrix = GetMatrix(m, n, 0, 10);


int [,] GetMatrix(int rowsCount, int columnsCount, int minValue, int maxValue)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random random = new Random();
    for( int i = 0; i < matrix.GetLength(0); i ++)
    {
       for ( int j = 0; j < matrix.GetLength(1); j ++)
       {
        matrix[i,j] = random.Next(minValue, maxValue);
       }
    }
    return matrix;
}
PrintMatrix(ourMatrix);

void PrintMatrix(int[,] matrix)
{
      for( int i = 0; i < matrix.GetLength(0); i ++)
    {
       for ( int j = 0; j < matrix.GetLength(1); j ++)
       {
        Console.Write(matrix[i, j] + " ");
       }
       Console.WriteLine();
    } 
}

int [,] newMatrix = SortingStringMatrix(ourMatrix);
PrintMatrix(newMatrix);
int [,] SortingStringMatrix(int[,]matrix)
{
   for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); i++)
        {
            for(int k = 0; k < matrix.GetLength(1)-1; k++)
            {
                
                if (matrix[i, k] > matrix[i, k + 1])
                {
                    int temp = matrix[i, k];
                    matrix[i,k] = matrix[i, k + 1];
                    matrix[i, k+1] = temp;

                }
            }

        }
    }

    return matrix;
}
