// Задайте две матрицы.Напишите программу, которая будет находить произведение двух матриц

Console.WriteLine("Enter m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n");
int n = Convert.ToInt32(Console.ReadLine());

int[,] ourMatrix = GetMatrix(m, n, -10, 10);


int[,] GetMatrix(int rowsCount, int columnsCount, int minValue, int maxValue)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(minValue, maxValue);
        }
    }
    return matrix;
}

int[,] ourMatrix2 = GetMatrix2(m, n, -10, 10);

int[,] GetMatrix2(int rowsCount, int columnsCount, int minValue, int maxValue)
{
    int[,] matrix2 = new int[rowsCount, columnsCount];
    Random random = new Random();
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = random.Next(minValue, maxValue);
        }
    }
    return matrix2;
}
PrintMatrix(ourMatrix);
Console.WriteLine();
PrintMatrix(ourMatrix2);
Console.WriteLine();

MultiplMatrix(ourMatrix, ourMatrix2, m,n);

void MultiplMatrix(int [,]matrix, int[,]matrix2, int rowsCount, int columnsCount )
{
    int[,] newMatrix = new int [rowsCount, columnsCount];
   for(int i= 0; i < newMatrix.GetLength(0); i++ )
   {
    for (int j = 0; j < newMatrix.GetLength(1); j++)
    {
        newMatrix[i,j] = matrix[i,j] * matrix2[i,j];
    }
    
   }
   for( int i = 0; i < newMatrix.GetLength(0); i++)
   {
    for (int j =0; j < newMatrix.GetLength(1); j++)
    {
        Console.Write(newMatrix[i,j] + " ");
    }
    Console.WriteLine();
   }
}




void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}