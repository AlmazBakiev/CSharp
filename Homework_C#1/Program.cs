firstTask();
secondTask();
thirdTask();
fourthTask();

////////////////////
// Первое задание //
////////////////////
static void firstTask()
{
    Console.Write("Введите первое число: ");
    int firstNumber = int.Parse(Console.ReadLine());

    Console.Write("Введите второе число: ");
    int secondNumber = int.Parse(Console.ReadLine());

    if (firstNumber > secondNumber) Console.WriteLine("Первое число больше второго.");
    else Console.WriteLine("Второе число больше первого.");
}


////////////////////
// Второе задание //
////////////////////
static void secondTask()
{
    Console.Write("Введите первое число: ");
    int firstNumber = int.Parse(Console.ReadLine());

    Console.Write("Введите второе число: ");
    int secondNumber = int.Parse(Console.ReadLine());

    Console.Write("Введите третье число: ");
    int thirdNumber = int.Parse(Console.ReadLine());

    if (firstNumber > secondNumber && firstNumber > thirdNumber) Console.WriteLine("Первое число больше второго и третьего.");
    else if (secondNumber > firstNumber && secondNumber > thirdNumber) Console.WriteLine("Второе число больше первого и третьего.");
    else Console.WriteLine("Третье число больше первого и второго.");
}


////////////////////
// Третье задание //
////////////////////
static void thirdTask()
{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine("Число " + number + ((number & 1) == 0 ? " четное." : " нечетное."));
}


///////////////////////     
// Четвертое задание //     
///////////////////////    
static void fourthTask()
{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    for (int i = 1; i <= number; i++)
    {
        Console.Write(((i & 1) == 0) ? i + " " : "");
    }
}