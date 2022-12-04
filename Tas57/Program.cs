// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
//информацию о том, сколько раз встречается элемент входных данных
//  1 2 3 
//  4 6 1
//  2 1 6 
// 1 встречается 3 раза
// 2 встречается 2 раза
// 3 встречается 1 раза
// 4 встречается 1 раза
// 6 встречается 2 раза

Console.WriteLine("Enter m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n");
int n = Convert.ToInt32(Console.ReadLine());

int[,] ourMatrix = GetMatrix(m, n, 0, 9);


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
PrintRepeatsOfElemwnts(ourMatrix);

void PrintRepeatsOfElemwnts(int[,] matrix)
{
int[] repeats = new int [10];

  for( int i = 0; i < matrix.GetLength(0); i ++)
    {
       for ( int j = 0; j < matrix.GetLength(1); j ++)
       {
        //  int index  = matrix[i,j];
        //  repeats[index]++;
        repeats[matrix[i,j]]++; // в качестве индекса линейного массива берем значение двумерного массива
       }
    }
    for(int i = 0; i < repeats.Length; i++)
    {
        if (repeats[i] > 0)// т.е. значения линейного массива заполнены
        {
          Console.WriteLine($"Quantity of repeats {i} = {repeats[i]}");
        }
    }
      
}
    


