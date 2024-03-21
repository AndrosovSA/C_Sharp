// Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, 
// состоящий из средних арифметических значений по строкам двумерного массива.


double[,] CreatTable(int rowCount, int columnCount, int min, int max)
{
    double[,] table = new double[rowCount, columnCount];
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
void PrintTable(double[,] table)
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

double[] ArrayAverageRow(double[,] table)
{
    double[] array = new double[table.GetLength(0)];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        double sumRow = 0;
        for (int j = 0; j < table.GetLength(1); j++)
        {
            sumRow = sumRow + table[i, j];
        }
        array[i] = sumRow / table.GetLength(1);
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

Console.WriteLine("Введите количество строк: ");
int rowCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columnCount = Convert.ToInt32(Console.ReadLine());
double[,] tableResult = CreatTable(rowCount, columnCount, 1, 10);
Console.WriteLine("Таблица случайных чисел");
PrintTable(tableResult);
Console.WriteLine("Массив");
double[] arrayResult = ArrayAverageRow(tableResult);
PrintArray(arrayResult);