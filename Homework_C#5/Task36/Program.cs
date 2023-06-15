int[] array = GetAndGenerateElementsInArray();
PrintArray(array);
SumEvenIndices(array);

int[] GetAndGenerateElementsInArray()
{
    Random random = new Random();
    int[] result = new int[5];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(-9, 10);
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

void SumEvenIndices(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }
    Console.WriteLine(" -> " + result);
}