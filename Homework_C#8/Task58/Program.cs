Console.Clear();

int rows = Prompt("Введите количество строк массива: ");
int columns = Prompt("Введите количество столбцов массива: ");
int[,] firstMatrix = GetArray(rows, columns);

rows = Prompt("Введите количество строк массива: ");
columns = Prompt("Введите количество столбцов массива: ");
int[,] secondMatrix = GetArray(rows, columns);

if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
{
    PrintArray(firstMatrix);
    PrintArray(secondMatrix);
    int[,] res = MatrixMultiplication(firstMatrix, secondMatrix);
    PrintArray(res);
}
else
{
    Console.WriteLine("Матрица не согласованные");
}

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[,] GetArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.Next(0, 10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MatrixMultiplication(int[,] firstArray, int[,] secondArray)
{
    Console.WriteLine("Результирующая матрица будет:");
    int[,] result = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            for (int z = 0; z < secondArray.GetLength(0); z++)
            {
                result[i, j] += firstArray[i, z] * secondArray[z, j];
            }
        }
    }
    return result;
}