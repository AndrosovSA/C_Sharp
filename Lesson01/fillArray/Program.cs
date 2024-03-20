Random rnd = new Random();

int size = 5;
int[] array_rnd = new int[size];
int i = 0;
while (i < size)
{
    array_rnd[i] = rnd.Next(1, 10);
    i++;
}
i = 0;
while (i < size)
{
    Console.Write($"{array_rnd[i]} ");
    i++;
}

Console.WriteLine("- массив случайных чисел");
i = 0;
int[] array_hand = new int[size];
while (i < size)
{
    Console.WriteLine("Введите элемент массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    // string input = Console.ReadLine();
    array_hand[i] = Convert.ToInt32(n);
    i++;
}
i = 0;
while (i < size)
{
    Console.Write($"{array_hand[i]} ");
    i++;
}
Console.WriteLine("- массив введен с клавиатуры");