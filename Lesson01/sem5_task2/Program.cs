// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
// (с индексами  (0,0); (1;1) и т.д.

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
int SumElementMainDiagonal(int[,] table)
{
    int result = 0;
    for (int i = 0; i < table.GetLength(0) && i < table.GetLength(1); i++)
    {
        result = result + table[i, i];
    }
    return result;
}

Console.WriteLine("Введите количество строк: ");
int rowCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columnCount = Convert.ToInt32(Console.ReadLine());
int[,] tableResult = CreatTable(rowCount, columnCount, 1, 10);
Console.WriteLine("Таблица случайных чисел");
PrintTable(tableResult);
Console.WriteLine("Сумма диаголей: ");
int SumMainDiagonal = SumElementMainDiagonal(tableResult);
Console.WriteLine(SumMainDiagonal);
