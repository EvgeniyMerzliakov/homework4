
// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

char RandomSymbol()
{
    Random rnd = new Random();
    int rndAskii = rnd.Next(33, 127);
    char rndChar = (char)rndAskii;
    return rndChar;
}

char[] CreateArray(int quantity)
{
    char[] chars = new char[quantity];
    for (int i = 0; i < chars.Length; i++)
        chars[i] = RandomSymbol();
    return chars;
}

void PrintReverseArray(char[] chars, int quantity)
{
    if (quantity == 0)
        return; 
    Console.Write("   " + chars[quantity - 1]);
    PrintReverseArray(chars, quantity - 1);
}

Console.WriteLine("Введите количество элементво в массиве: ");
int quantity = int.Parse(Console.ReadLine()!);
char[] chars = CreateArray(quantity);
Console.Write($"Массив: {string.Join("   ", chars)}");
Console.WriteLine();
Console.Write($"Реверсивный массив: ");
PrintReverseArray(chars, quantity);