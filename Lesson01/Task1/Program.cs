// Находим самую тяжелую гирю
// int a = 100;
// int b = 200;
// int c = 300;
// int d = 400;
// int f = 5;

// int max = a;

// if (b > max)
// {
//     max = b;
// }
// if (c > max)
// {
//     max = c;
// }
// if (d > max)
// {
//     max = d;
// }
// if (f > max)
// {
//     max = f;
// }
// Console.WriteLine(max);

// Решение задачи с использованием массива

// int[] array = { 100, 200, 300, 400, 5 };
// int i = 0;
// int max = array[0];

// while (i < array.Length)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
//     i = i + 1;
// }
// Console.WriteLine(max);

// Цикл for

// int[] array = { 100, 200, 300, 400, 5 };
// int max = array[0];

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
// }
// Console.WriteLine(max);

// Цикл foreach

int[] array = { 100, 200, 300, 400, 5 };
int max = array[0];

foreach (int e in array)
{
    if (e > max)
    {
        max = e;
    }
}
Console.WriteLine(max);