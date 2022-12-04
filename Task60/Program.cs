// Сформируйте трехмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента
Console.WriteLine("Enter m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter c");
int c = Convert.ToInt32(Console.ReadLine());

int[, ,] ourMatrix = GetMatrix(m, n, c, 10, 100);


int[, ,] GetMatrix(int rowsCount, int columnsCount, int cCount, int minValue, int maxValue)
{
    int[, ,] matrix = new int[rowsCount, columnsCount,  cCount];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for ( int k = 0; k < matrix.GetLength(2); k++)
            {
            matrix[i, j, k] = random.Next(minValue, maxValue);
            }
        }
    }
    return matrix;
}
PrintMatrix(ourMatrix);

void PrintMatrix(int[, ,] matrix)
{
    int [] repeats = new int [100];// 100 - макс. значение, значит в новой матрице подсчета будет 100 эл-тов
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
            repeats[matrix[i,j,k]]++;// заполняем матрицу, где индексы - это значение элементов
            // матрицы matrix. Если таких элементов например два, то по этому индексу заполнится
            // два элемента, если три - то три и т.д. Т.е. значение элементов матрицы repeats 
            // будет количество одинаковых элементов в матрице matrix
            }
        }
        
    }

    for (int i= 0; i < repeats.Length; i++)
    {
        if(repeats[i] > 1)
        {
            Console.WriteLine($"Number{i} repeats {repeats[i] } times. Please repeats more");
        }
    }


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
            //Console.Write(matrix[i, j, k] + " ");
            Console.Write($"{matrix[i,j,k]} i = {i}, j = {j}, k = {k}; ");
            }
        }
        
    }
}
