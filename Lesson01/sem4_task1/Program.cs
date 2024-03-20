﻿// // Задайте одномерный массив, заполненный случайными числами. 
// Определите количество простых чисел в этом массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3


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
int CountPrime(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (IsPrime(array[i])) count++;
    }
    return count;
}

bool IsPrime(int num)
{
    for (int i = 2; i < Math.Sqrt(num); i++)
    {
        if (num % i == 0) return false;
    }
    return true;
}

int[] arrayResult = CreatArrayRnd(10, 2, 21);
PrintArray(arrayResult);
int result = CountPrime(arrayResult);
Console.Write(result);