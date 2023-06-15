int[,] array = GetArray();
PrintArray(array);
string index = Prompt("Введите номер строки и столбца через запятую: ");
Console.WriteLine(SearchElement(array, index));

string Prompt(string message)
{
    Console.Write(message);
    return Console.ReadLine()!;
}

int[,] GetArray()
{
    int[,] result = new int[5, 5];
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

string SearchElement(int[,] array, string index)
{
    string[] strIndex = index.Replace(" ", "").Split(",");
    int rows = int.Parse(strIndex[0]);
    int columns = int.Parse(strIndex[1]);
    if (rows >= 0 && rows < array.GetLength(0) && columns >= 0 && columns < array.GetLength(1))
    {
        return $"{array[rows, columns]}";
    }
    return "Такого элемента нет";
}