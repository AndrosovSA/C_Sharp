// Программа определяет кол-во четных чисел в заданном массиве

int[] array = { 1, 5, 10, 20, 30, 40, 99, 4, 9, 3 };
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) count = count + 1;
}

Console.WriteLine(count);
