// Задайте прямоугольный двумерный массив.Напишите программу, которая будет находить строку
//с наименьшей суммой элементов

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
Console.WriteLine();
MinStringSum(ourMatrix);
void MinStringSum(int[,]matrix)
{
    int[] arr = new int [matrix.GetLength(0)];
    int sum = 0;
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        
                sum = sum + matrix[i,j];
                
        }
         arr[i] = sum;
        sum = 0;
    }
    int min = arr[0];
    int minIndex = 0;
    for(int i= 0; i < arr.Length; i++)
    {
    if(arr[i] < min)
    {
    min = arr[i];
    minIndex =  i;
    }
    } 
    Console.WriteLine($"String with min summ is {minIndex + 1}");
}