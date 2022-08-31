// Показать двумерный массив размером m×n заполненный вещественными числами

int[,] CreateMatrix(int length, int width, int min, int max)
{
    int[,] matrix = new int[length, width];
    var random = new Random();
    for(int i=0;i<matrix.GetLength(0);i++)
        for(int j=0;j<matrix.GetLength(1);j++)
            matrix[i,j] = random.Next(min, max);
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i=0;i<matrix.GetLength(0);i++)
    {
        for(int j=0;j<matrix.GetLength(1);j++)
            Console.Write($"{matrix[i,j]} ");
        Console.WriteLine();
    }

}

Console.WriteLine("Введите число строк в массиве (m): ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число строк в массиве (n): ");
int n = int.Parse(Console.ReadLine());

int[,] matrix = CreateMatrix(m, n, 1, 10);
PrintMatrix(matrix);
