Console.Clear();

int rows = Prompt("Введите количество строк массива: ");
int columns = Prompt("Введите количество столбцов массива: ");

if (rows != columns)
{
    int[,] array = GetArray(rows, columns);
    PrintArray(array);
    Console.WriteLine(SearchLowerSum(array));
}
else
{
    Console.WriteLine("Матрица не прямоугольная");
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
}

string SearchLowerSum(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[i, j];
        }
    }
    int min = sum[0];
    int lineNumber = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        if (sum[i] < min)
        {
            min = sum[i];
            lineNumber = i;
        }
    }
    return $"Номер строки с наименьшей суммой элементов: {lineNumber + 1}";
}