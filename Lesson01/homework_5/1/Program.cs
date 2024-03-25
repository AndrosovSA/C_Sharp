// Программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет:
// "Позиция по рядам выходит за пределы массива" или "Позиция по колонкам выходит за пределы массива"
// int[,] array = new int[,] {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// };

// int x = 2;
// int y = 4;

int FindElementByPosition(int[,] array, int x, int y)
{
    int element = array[x - 1, y - 1];
    return element;
}
bool ValidatePosition(int[,] array, int x, int y)
{
    if (x < array.GetLength(0)+1 && y < array.GetLength(1)+1)
    {
        return true;
    }
    else
    {
        if(x >= array.GetLength(0)+1)
        {
        Console.WriteLine("Позиция по рядам выходит за пределы массива");
        }
        if(y >= array.GetLength(1)+1)
        {
        Console.WriteLine("Позиция по колонкам выходит за пределы массива");
        }
        return false;

    }
}
void PrintTable(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($"{table[i, j] }  ");
        }
        Console.WriteLine();
    }
}
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
void PrintResult(int[,] array, int x, int y)
{
    if(ValidatePosition(array, x, y) == true)
    {
    int ElementResult = FindElementByPosition(array, x, y);
    Console.WriteLine(ElementResult);
    }
}
Console.WriteLine("Введите количество строк: ");
int rowCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columnCount = Convert.ToInt32(Console.ReadLine());
int[,] tableResult = CreatTable(rowCount, columnCount, 1, 10);
Console.WriteLine("Таблица случайных чисел");
PrintTable(tableResult);
Console.WriteLine("Номер строки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Номер столбца: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Значение по заданным параметрам");
PrintResult(tableResult, x, y);