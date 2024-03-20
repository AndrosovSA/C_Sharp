// Программа, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.


while (true)
{
    Console.Write("Введите число: ");
    string? input = Console.ReadLine(); // чтение строки ввода пользователя
    if (input == "q") break;
    int number;
    if (int.TryParse(input, out number))
    {
        int sum = sumDigit(number);
        if (sum % 2 == 0)
        {
            Console.Write("STOP!!! Суума цифр четное число. Выход  из цикла.");
            break;
        }
    }
    else
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q'.");
    }
}
int sumDigit(int n)
{
    int sum = 0;
    while (n > 0)
    {
        sum = sum + n % 10;
        n = n / 10;
    }
    return sum;
}