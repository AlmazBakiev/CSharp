int[] array = GetAndGenerateElementsInArray();
PrintArray(array);
SearchForAnEvenNumbers(array);

int[] GetAndGenerateElementsInArray()
{
    Random random = new Random();
    int[] result = new int[5];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(100, 1000);
    }
    return result;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    foreach (int el in array)
    {
        Console.Write($"{el} ");
    }
    Console.Write("]");
}

void SearchForAnEvenNumbers(int[] array)
{
    int counter = 0;
    foreach (int el in array)
    {
        if ((el & 1) == 0)
        {
            counter++;
        }
    }
    Console.WriteLine(" -> " + counter);
}