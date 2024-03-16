// Программа выводит разницу между максимальным и минимальным значениями массива


double[] array = { 1.1, 2, 4, 0.4, 9.5 };
double min = array[0];
double max = array[0];
double result = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
}

result = max - min;

Console.WriteLine(result);
