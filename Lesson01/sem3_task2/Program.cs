// Программа которая менят знак у вскех элементов массива

int[] array = { 1, 3, 4, -19, 3 };

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    if (i < array.Length - 1) Console.Write(array[i] + ",");
    else Console.Write(array[i]);
}


