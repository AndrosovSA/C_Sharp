// Задан одномерный массив из 10 целых чисел от 1 до 100.
// Программа находти количество элементов массива, значения которых лежат в отрезке [10,90].

int[] array = { 1, 5, 10, 20, 30, 4, 99, 4, 90, 3 };
int[] numbers = new int[10];
int minRange = 10;
int maxRange = 90;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] >= minRange && array[i] <= maxRange)
//     {
//         numbers[i] = array[i];
//     }
// }
// int count = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > 0) count = count + 1;
// }
// Console.WriteLine(count);

int result = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= minRange && array[i] <= maxRange)
    {
        result++;
    }
}

Console.WriteLine(result);