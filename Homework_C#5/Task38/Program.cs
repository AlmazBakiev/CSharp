double[] array = GetAndGenerateElementsInArray();
double min = array[0];
double max = array[0];
PrintArray(array);
SearchMinMax(array);

double[] GetAndGenerateElementsInArray()
{
    Random random = new Random();
    double[] result = new double[5];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.NextDouble() * 10 - 5;
    }
    return result;
}

void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{string.Format("{0:F2}", array[i])} ");
    }
    Console.Write("]");
}

void SearchMinMax(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
        if (max < array[i]) max = array[i];
    }
    Console.WriteLine($" => {string.Format("{0:F2}", max)} - {string.Format("{0:F2}", min)} = {string.Format("{0:F2}", max - min)}");
}