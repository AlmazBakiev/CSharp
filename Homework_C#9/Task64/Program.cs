Console.Clear();

int number = Prompt("Введите число: ");
Console.WriteLine(PrintNumbers(number));

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

string PrintNumbers(int number)
{
    if (number == 1) return "1";

    return $"{number} {PrintNumbers(number - 1)}";
}