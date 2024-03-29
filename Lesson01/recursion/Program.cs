// Вычислениее факториала заданного числа
int factorial(int n)
{
    if (n == 1 || n == 0)
    {
        return 1;
    }
    return n * factorial(n - 1);
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = factorial(n);
Console.Write("Ответ: ");
Console.Write(result);

// Матрешка

// void OpenMatryoshka(int size)
// {
//     if (size == 0)
//     {
//         return;
//     }
//     OpenMatryoshka(size - 1);
//     Console.WriteLine($"Матрешка {size} ");
// }
// Console.Write("Введите число матрешек: ");
// int size = Convert.ToInt32(Console.ReadLine());
// OpenMatryoshka(size);