// определить четное или нечетное заданное число
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int i = number % 2;
// if (i > 0)
// {
//     Console.WriteLine("нечетное");
// }
// else
// {
//     Console.WriteLine("четное");
// }

// Программа которая выводит все четные числа в заданном массиве

int[] array = { 4, 15, 134, 1, 1, 600, 56, 456, 4, 35, 33, 34 };
int i = 0;

while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
    Console.Write(array[i] + " ");
    }
    i = i +1;
}