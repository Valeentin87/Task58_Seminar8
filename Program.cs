
Console.WriteLine("Введите количество строк в 1 массиве");
bool row = int.TryParse(Console.ReadLine(), out int rows);
Console.WriteLine("Введите количество колонок в 1 массиве");
bool column = int.TryParse(Console.ReadLine(), out int columns);

Console.WriteLine("Введите количество строк в 2 массиве");
bool row1 = int.TryParse(Console.ReadLine(), out int rowses);
Console.WriteLine("Введите количество колонок в 2 массиве");
bool column1 = int.TryParse(Console.ReadLine(), out int columnes);


int[,] matrixA = FillArray(rows, columns);
int[,] matrixB = FillArray(rowses, columnes);
PrintArray2D(matrixA);
Console.WriteLine();
PrintArray2D(matrixB);
Console.WriteLine();
int[,] multiMatrix = MatrixC(matrixA, matrixB);
PrintArray2D(multiMatrix);

int[,] FillArray(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(0, 100);
        }
    }
    return array;
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} | ");
        }
        Console.WriteLine();
    }
}
int[,] MatrixC(int[,] matrA, int[,] matrB)
{
    if (matrA.GetLength(1) != matrB.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] resMatrix = new int[matrA.GetLength(0), matrB.GetLength(1)];
    for (int i = 0; i < matrA.GetLength(0); i++)
    {
        for (int j = 0; j < matrB.GetLength(1); j++)
        {
            for (int k = 0; k < matrB.GetLength(0); k++)
            {
                resMatrix[i, j] += matrA[i, k] * matrB[k, j];
            }
        }
    }
    return resMatrix;
}

