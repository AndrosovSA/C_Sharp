// Задайте массив. Напишите программу, которая определяет, присутствует  ли  заданное  число  в  
// массиве.  Программа должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

int[] array = { 1, 3, 4, 19, 3 };
int n = 19;
bool isExistNum = false;


Console.Write("Массив:");

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();

Console.WriteLine("Искомое число: " + n);
for (int i = 0; i < array.Length; i++)
{
    if(array[i] == n)
    {
        isExistNum = true;
        break;
    }
}
Console.WriteLine(isExistNum ? "Да, число есть в массиве" : "Нет такого числа в массиве");

// if(isExistNum) Console.WriteLine("Да");
// else Console.WriteLine("Нет");