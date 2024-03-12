// Напишите программу, которая выводит третью цифру слева или сообщает, что третьей цифры нет

// 456 => 6
// 7812 => 1
// 91 => Третьей цифры нет


Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 0)
{
    n = n * -1;
}
if (n < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (n > 999)
    {
        n = n / 10;
    }

    Console.WriteLine(n % 10);
}