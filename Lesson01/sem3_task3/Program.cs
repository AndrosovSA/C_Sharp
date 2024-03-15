// Программа находит произведение пар чисел массива. парой считаем
// первый и последний элемент второй и предпоследний и т.д.
// результат выводится в новый массив


int[] array = { 2, 2, 2, 2, 3, 4 };
int[] resultArray = new int[array.Length / 2];

// Заполнение нового массива
for (int i = 0; i < array.Length / 2; i++)
{
    resultArray[i] = array[i] * array[array.Length - 1 - i];
}
// Вывод нового массива
for (int i = 0; i < resultArray.Length; i++)
{
    Console.Write(resultArray[i] + " ");
}