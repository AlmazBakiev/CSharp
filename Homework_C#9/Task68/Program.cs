Console.Clear();

int m = Prompt("Введите число m: ");
int n = Prompt("Введите число n: ");
Console.WriteLine(A(m, n));

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int A(int firstNumber, int secondNumber)
{
    if (firstNumber == 0) return secondNumber + 1;
    else if (firstNumber != 0 && secondNumber == 0) return A(firstNumber - 1, 1);
    else return A(firstNumber - 1, A(firstNumber, secondNumber - 1));
}