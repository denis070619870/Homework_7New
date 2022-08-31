// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

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
            Console.Write($"{matrix[i,j]} \t ");
        Console.WriteLine();
    }

}
int[] NumberPosition(int[,] matrix, int value)
{
    for(int i=0;i<matrix.GetLength(0);i++)
        for(int j=0;j<matrix.GetLength(1);j++)
            if(matrix[i,j]==value)
                return new int[]{i,j};
    return new int[] {-1,-1};  
}

Console.Clear();
int m = 5;
int n = 5;
int[,] matrix = CreateMatrix(m, n, 1, 100);
PrintMatrix(matrix);

Console.Write("Введите номер элемента, чтобы узнать его координаты: : ");
int value = int.Parse(Console.ReadLine() ?? "0");
int[] position = NumberPosition(matrix,value);
Console.WriteLine(position[0]< 0 || position[1]< 0
    ? "Такого элемента нет в массиве"
    : $"Элемент имеет координаты: строка ({position[0]} , {position[1]}) столбец.");
