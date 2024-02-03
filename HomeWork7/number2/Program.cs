
// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int CalculatingAckermanFormula(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return CalculatingAckermanFormula(m - 1, 1);
    else
        return CalculatingAckermanFormula(m - 1, CalculatingAckermanFormula(m, n - 1));
}

Console.Write("Введите значение m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение n: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(CalculatingAckermanFormula(m, n));



