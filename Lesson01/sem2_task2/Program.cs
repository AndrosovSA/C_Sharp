// Программа, которая принимает на вход трехзначное число
// и возводит вторую цифру этого чисоа в степень, равную третьей цифре.


Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 100 && n <= 999)
{
    int secondDigit = n / 10 % 10;
    int numDegree = n % 10;
    int result = 1;
    int count = 0;
    while(count < numDegree)
    {
        result *= secondDigit; // result = result * secondDigit;
        count++;
    }
    Console.WriteLine(result);
}
else Console.WriteLine("Некорректноый ввод");