// Программа создает строку из двумерного массива

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
string stringFromAraay(int[,] table)
{
    string str = string.Empty;
    foreach (int e in table)
    {
        str = str + e;
    }
    return str;
}
Console.WriteLine("Введите количество строк: ");
int rowCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columnCount = Convert.ToInt32(Console.ReadLine());
int[,] tableResult = CreatTable(rowCount, columnCount, 1, 10);
Console.WriteLine("Таблица случайных чисел");
PrintTable(tableResult);
Console.WriteLine("Строка полученная из массива");
string stringResult = stringFromAraay(tableResult);
Console.WriteLine(stringResult);