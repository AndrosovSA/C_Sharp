// Программa, которая поменяет местами первую и последнюю строку массива.
int[,] numbers = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };

int[,] SwapFirstLastRows(int[,] array)
{
    SwapItems(array, 0);
    return array;
}
void SwapItems(int[,] array, int i)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[i, j];
        array[i, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temp;
    }
}
void PrintTable(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}
int[,] ResultTable = SwapFirstLastRows(numbers);
PrintTable(ResultTable);
