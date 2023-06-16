Console.Clear();

int rows = Prompt("Введите количество строк массива: ");
int columns = Prompt("Введите количество столбцов массива: ");
int layer = Prompt("Введите количество слоев массива: ");
int[,,] array = GetArray(rows, columns, layer);
PrintArray(array);


int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[,,] GetArray(int rows, int columns, int layer)
{
    int[,,] result = new int[rows, columns, layer];
    int[] isExist = new int[100];
    Random random = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int z = 0; z < result.GetLength(2); z++)
            {
                int number = 0;
                int counterForExit = 0;
                while (true)
                {
                    counterForExit++;
                    number = random.Next(10, 100);
                    if (isExist[number] == 0) break;
                    if (counterForExit == 100) return result;
                }
                result[i, j, z] = number;
                isExist[result[i, j, z]]++;
            }
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int z = 0; z < inArray.GetLength(2); z++)
            {
                Console.Write($"{inArray[i, j, z]}({j},{z},{i}) ");
            }
            Console.WriteLine();
        }
    }
}