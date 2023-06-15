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
    int firstNumber = int.Parse(Console.ReadLine()!);

    Console.Write("Введите второе число: ");
    int secondNumber = int.Parse(Console.ReadLine()!);

    if (firstNumber > secondNumber) Console.WriteLine("Первое число больше второго.");
    else if (firstNumber > secondNumber) Console.WriteLine("Второе число больше первого.");
    else Console.WriteLine("Значения равны.");
}


////////////////////
// Второе задание //
////////////////////
static void secondTask()
{
    Console.Write("Введите первое число: ");
    int firstNumber = int.Parse(Console.ReadLine()!);

    Console.Write("Введите второе число: ");
    int secondNumber = int.Parse(Console.ReadLine()!);

    Console.Write("Введите третье число: ");
    int thirdNumber = int.Parse(Console.ReadLine()!);

    if (firstNumber == secondNumber && secondNumber == thirdNumber) Console.WriteLine("Значения трех чисел равны.");
    else if (firstNumber == secondNumber && firstNumber > thirdNumber) Console.WriteLine("Первое и второе число больше третьего.");
    else if (firstNumber > secondNumber && firstNumber == thirdNumber) Console.WriteLine("Первое и третье число больше второго.");
    else if (secondNumber > firstNumber && secondNumber == thirdNumber) Console.WriteLine("Второе и третье число больше первого.");
    else if (firstNumber > secondNumber && firstNumber > thirdNumber) Console.WriteLine("Первое число больше второго и третьего.");
    else if (secondNumber > firstNumber && secondNumber > thirdNumber) Console.WriteLine("Второе число больше первого и третьего.");
    else Console.WriteLine("Третье число больше первого и второго.");

}


////////////////////
// Третье задание //
////////////////////
static void thirdTask()
{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Число " + number + ((number & 1) == 0 ? " четное." : " нечетное."));
}


///////////////////////     
// Четвертое задание //     
///////////////////////    
static void fourthTask()
{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine()!);
    for (int i = 2; i <= number; i++)
    {
        Console.Write(((i & 1) == 0) ? i + " " : "");
    }
}