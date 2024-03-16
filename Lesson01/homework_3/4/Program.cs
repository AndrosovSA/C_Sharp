// Программа создает массив из цифр заданного числа, (последовотельность массива от старшего разряда к младшему).
Console.Write("Введите число в диапазоне от 1 до 100 000: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[6];
int i = 0;
if (n > 1 && n < 100000)
{
    // определяем разрядность числа
    int numDigit = 1;
    while (n / numDigit >= 10)
    {
        numDigit = numDigit * 10;
    }
    // далее
    while (numDigit > 0)
    {
        int result = n / numDigit;
        array[i] = result;
        n = n % numDigit;
        numDigit = numDigit / 10;
        Console.Write(array[i] + " ");
    }
}
else
{
    Console.Write("Некорректный ввод числа");
}