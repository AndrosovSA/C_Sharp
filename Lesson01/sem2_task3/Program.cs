// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первоe число 
// кратным втромуому. Если второе число некратно первому, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int remainder = num1 % num2;

if (remainder == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.Write("нет, " + remainder);
}