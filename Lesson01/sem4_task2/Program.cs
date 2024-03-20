// Задайте массив  х целых чисел (N вводится с клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

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
int NumberChek(int[] array, int lastDigit, int multiplicity)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 10 == lastDigit && array[i] % multiplicity == 0) count++;
    }
    return count;
}
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arrayResult = CreatArrayRnd(n, 1, 100);
PrintArray(arrayResult);
int result = NumberChek(arrayResult, 3, 9);
Console.Write(result);
// Console.WriteLine(NumberChek(newArray));
