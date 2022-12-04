// задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю
// строку массива.

Console.WriteLine("Enter m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n");
int n = Convert.ToInt32(Console.ReadLine());

int[,] ourMatrix = GetMatrix(m, n, -10, 10);


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
ChangeRows(ourMatrix);

void ChangeRows(int[,] matrix)
{
    
      for( int i = 0; i < matrix.GetLength(1); i ++)
    {
       
        int temp = matrix[0,i];
        matrix[0,i] = matrix[matrix.GetLength(0)-1, i];
         matrix[matrix.GetLength(0)-1,i] = temp;

       
       Console.WriteLine();
    } 
}
PrintMatrix(ourMatrix);