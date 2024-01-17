
while (true)
{
    Console.Write("Enter number: ");
    string text = Console.ReadLine();
    if (text == "q")
    {
        break;
    }
    int number;
    if (int.TryParse(text, out number))// == true
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        if (sum % 2 == 0)
        {
            break;
        }
    }
}







int[] CreateArray(int lengthFA)
{
    int[] array = new int[lengthFA];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int ShowCountEvenNumbers(int[] array)
{
    int count = 0;
    foreach (int e in array)
    {
        if (e % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите величину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(length);
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
Console.WriteLine($"Количество четных чисел: {ShowCountEvenNumbers(array)}");








int[] CreateArray(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

int[] FlipArray(int[] array, int N)
{
    int[] reservArray = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
        reservArray[i] = array[array.Length - 1 - i];
    }
    return reservArray;
}


Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(N);
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
int[] reservArray = FlipArray(array, N);
Console.WriteLine($"Массив: [ {string.Join("; ", reservArray)} ]");