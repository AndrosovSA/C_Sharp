//  Программа, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

int[] CreatArrayRnd(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 20);
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
    Console.Write("]");
}
int[] CreatReversArray(int[] array)
{
    int[] arr = new int[array.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = array[array.Length - 1 - i];
    }
    return arr;
}

Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = CreatArrayRnd(n);
PrintArray(array);
Console.WriteLine();
int[] arrayResult = CreatReversArray(array);
PrintArray(arrayResult);