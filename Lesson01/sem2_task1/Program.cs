// Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую цифру этого числа.
// Примеры
// a = 256  => 26
// a = 891  => 81

Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 100 && n <= 999 || n >= -999 && n <= -100)
{
    int firstDigit = n / 100; // 256 / 100 = 2.56 =>2 
    int LastDigit = n % 10;  // 256 % 10 = 250 + 6 =>6
    int result = firstDigit * 10 + LastDigit;
    Console.WriteLine("Результат: " + result);
}
else Console.WriteLine("Некорректноый ввод");
