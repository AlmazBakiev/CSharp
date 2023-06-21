Console.Clear();

int start = Prompt("Введите число от: ");
int end = Prompt("Введите число до: ");
Console.WriteLine(Sum(start, end));

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int Sum(int firstNumber, int secondNumber)
{
    if (secondNumber == firstNumber) return firstNumber;

    return secondNumber + Sum(firstNumber, secondNumber - 1);
}