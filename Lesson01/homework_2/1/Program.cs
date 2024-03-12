// Программа, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.


Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 7 == 0 && number % 23 == 0)
{
   Console.WriteLine("Да, число кратно одновременно 7 и 23"); 
}
else
{
    Console.WriteLine("Нет, число не является кратным одновременно 7 и 23"); 
}