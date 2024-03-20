// Программа элементы массива пробразует в число
// Пример: [1 3 2 4 2 3] => 132423

int[] CreatArrayRnd(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("] => ");
}

int ArrayToNumder(int[] array)
{
    int num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        num = 10 * num + array[i];
    }
    return num;
}


Console.WriteLine("Введите рамер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1 || n > 8)
{
    Console.WriteLine("Задан некорректный размер массива: ");
    return;
}
int[] arrayResult = CreatArrayRnd(n, 1, 10);
PrintArray(arrayResult);
int result = ArrayToNumder(arrayResult);
Console.WriteLine(result);
