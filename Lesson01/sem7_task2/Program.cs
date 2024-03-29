// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// Указание Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9
int sumDigit(int n)
{
    if (n == 0)
    {
        return 0;
    }
    return n % 10 + sumDigit(n/10);
}
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = sumDigit(n);
Console.Write("Ответ: ");
Console.Write(result);
