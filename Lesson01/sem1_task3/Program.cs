// Напишите  программу,  которая  принимает  на  вход трёхзначное целое число и на выходе показывает 
// сумму первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 100 && n <= 999)
{
    int firstDigit = n / 100;
    int LastDigit = n % 10;
    int sum = firstDigit + LastDigit;
    Console.WriteLine(sum);
}
else Console.WriteLine("Некорректноый ввод");
