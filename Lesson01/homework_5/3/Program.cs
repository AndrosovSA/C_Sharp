// Программа, которая будет находить строку с наименьшей суммой элементов.

int[,] CreatTable(int rowCount, int columnCount, int min, int max)
{
    int[,] table = new int[rowCount, columnCount];
    Random rnd = new Random();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = rnd.Next(min, max);
        }
    }
    return table;
}
void PrintTable(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($"{table[i, j],5}");
        }
        Console.WriteLine();
    }
}

int[] SumRows(int[,] table)
{
    int[] array = new int[table.GetLength(0)];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < table.GetLength(1); j++)
        {
            sumRow = sumRow + table[i, j];
        }
        array[i] = sumRow;
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.Write("]");
}
int MinIndex(int[] array)
{
    int min = array[0];
    int NunRow = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            NunRow = i;
        }
    }
    return NunRow;
}

Console.WriteLine("Введите количество строк: ");
int rowCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columnCount = Convert.ToInt32(Console.ReadLine());
int[,] tableResult = CreatTable(rowCount, columnCount, 1, 10);
Console.WriteLine("Таблица случайных чисел");
PrintTable(tableResult);
Console.WriteLine("Массив. Элементы массива: сумма строк таблицы");
int[] arrayResult = SumRows(tableResult);
PrintArray(arrayResult);
Console.WriteLine();
int result = MinIndex(arrayResult);
Console.WriteLine("Минимальное значение массива");
Console.WriteLine(result);