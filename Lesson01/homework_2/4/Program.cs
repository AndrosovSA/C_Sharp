// Программа, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

// Способ 1 (Выводит цифры в обратном порядку)

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// while (n>10)
// {
// int digit = n % 10;
// n = n / 10;

// Console.Write(digit);
// Console.Write(", ");
// }
// Console.Write(n);

// Способ 2

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

// определяем разрядность числа
int numDigit = 1;
while(n / numDigit >= 10) 
{
numDigit = numDigit * 10;
}
// далее
while(numDigit > 0)
{
int result = n / numDigit;
Console.Write(result + ", ");
// n = n - (result * numDigit);
n = n % numDigit;
numDigit = numDigit / 10;
}
