Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int i = number % 2;
if (i > 0)
{
    Console.WriteLine("нечетное");
}
else
{
    Console.WriteLine("четное");
}