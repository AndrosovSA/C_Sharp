// Вывести все четные числа от 1 до заданного
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 2;

while (i <= n)
{
    Console.Write(i);
    Console.Write(' ');
    i = i + 2;
}