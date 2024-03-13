// Программa, которая принимает на вход целое число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

Console.Write("Введите число от 10 до 99: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 10 && n <= 99)

{
int fierstDigit = n / 10;
int secondDigit = n % 10;

if(fierstDigit > secondDigit)
{
    Console.Write("max => " + fierstDigit);
}
else
{
    Console.Write("max => " + secondDigit);
}
}
else
{
    Console.Write("Некорректный ввод");
}