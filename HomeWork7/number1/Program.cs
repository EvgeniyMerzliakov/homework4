
// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void PrintNaturalNumbers(int M, int N)
{
    if (M == N)
    {
        Console.Write(M + " ");
        return;
    }
    if (M < N)
    {
        Console.Write(M + " ");
        PrintNaturalNumbers(M + 1, N);
    }
}

Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);

PrintNaturalNumbers(M, N);