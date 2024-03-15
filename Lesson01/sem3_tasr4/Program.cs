// Программа создает массив из трехзначного числа, 
// причем младший разряд имее индекс 0, а старший индекс 2

Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[3];

for (int i = 0; i < array.Length; i++)
{
    array[i] = n % 10;
    n = n / 10;
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}