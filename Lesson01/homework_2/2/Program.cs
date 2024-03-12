// Программа, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x == 0 || y == 0)
{
    Console.WriteLine("Некорректный ввод данных");
}
else
{
    if(x > 0 && y > 0)
    {
        Console.WriteLine("номер координатной четверти: 1");
    }
    if(x < 0 && y > 0)
    {
        Console.WriteLine("номер координатной четверти: 2");
    }
    if(x < 0 && y < 0)
    {
        Console.WriteLine("номер координатной четверти: 3");
    }
    if(x > 0 && y < 0)
    {
        Console.WriteLine("номер координатной четверти: 4");
    }
}