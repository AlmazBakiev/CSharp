internal class Program
{
    private static void Main(string[] args)
    {
        task19();
        task21();
        task23();
    }

    public static void task19()
    {
        int number = PromptForTask19("Введите число: ");
        if (number == int.MinValue) return;
        isPalindrome(number);
    }

    public static int PromptForTask19(String message)
    {
        Console.Write(message);
        String strNmber = Console.ReadLine()!;
        if (int.TryParse(strNmber, out int i))
        {
            return int.Parse(strNmber);
        }
        else
        {
            Console.WriteLine("Это не число!!!");
        }
        return int.MinValue;
    }

    public static void isPalindrome(int number)
    {
        if (number < 0)
        {
            Console.WriteLine(number + " -> нет!");
            return;
        }

        for (int i = 1_000_000_000, j = 1, z = 10; i > j; i /= 10)
        {
            if (number / i == 0) continue;
            if ((number / i % z) != (number / j % z))
            {
                Console.WriteLine(number + " -> нет!");
                return;
            }
            j *= 10;
        }
        Console.WriteLine(number + " -> да!");
    }

    public static void task21()
    {
        double x1 = PromptForTask21("Введите координаты х1: ");
        double y1 = PromptForTask21("Введите координаты y1: ");
        double z1 = PromptForTask21("Введите координаты z1: ");
        double x2 = PromptForTask21("Введите координаты x2: ");
        double y2 = PromptForTask21("Введите координаты y2: ");
        double z2 = PromptForTask21("Введите координаты z2: ");

        distanceSearch(x1, y1, z1, x2, y2, z2);
    }

    public static double PromptForTask21(String message)
    {
        Console.Write(message);
        return double.Parse(Console.ReadLine()!);
    }

    public static void distanceSearch(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        Console.WriteLine(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)));
    }

    public static void task23()
    {
        int number = PromptForTask23("Введите число: ");
        if (number > 0) PrintDegreeTableForPositiveNumber(number);
        else PrintDegreeTableForNegativeNumber(number);
    }

    public static int PromptForTask23(String message)
    {
        Console.Write(message);
        String strNmber = Console.ReadLine()!;
        if (int.TryParse(strNmber, out int i))
        {
            return int.Parse(strNmber);
        }
        else
        {
            Console.WriteLine("Это не число!!!");
        }
        return 0;
    }

    public static void PrintDegreeTableForPositiveNumber(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            Console.Write(Math.Pow(i, 3) + " ");
        }
    }

    public static void PrintDegreeTableForNegativeNumber(int number)
    {
        for (int i = number; i < 0; i++)
        {
            Console.Write(Math.Pow(i, 3) + " ");
        }
    }
}