// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.(Транспонирование 
// матрицы)
//В случае если это невозможно прграмма должна вывести сообщение для ползователя
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
PrintMatrix(ourMatrix);

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
int [,] tMatrix =  TrasporirMatrix(ourMatrix);

int [,] TrasporirMatrix(int[,] matrix)
{
    int[,] tMatrix = new int[matrix.GetLength(1),matrix.GetLength(0)];
    for (int i = 0; i < tMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tMatrix.GetLength(1); j++)
        {
            tMatrix[i, j] = matrix[j,i];
        }
    }
    return tMatrix ;

}
  Console.WriteLine();
PrintMatrix(tMatrix);