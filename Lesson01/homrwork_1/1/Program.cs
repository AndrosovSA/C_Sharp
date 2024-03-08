Console.WriteLine("firstNumber: ");
int num1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("secondNumber: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2)
{
    Console.WriteLine("числа равны");
}
else
{
if (num1 > num2)
{
    Console.WriteLine("первое число больше");
}
else
{
    Console.WriteLine("второе число больше");
}
}