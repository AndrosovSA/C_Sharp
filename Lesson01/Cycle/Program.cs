// Программа выводит все числа от 1 до n

// int n = 50;
// int i = 1;

// while (i <= n)
// {
//     Console.Write(i);
//     Console.Write('_');
//     i = i + 1;
// }

// Способ 2 с помощью массива

int n = 50;
int[] arr = new int[n];
int i = 0;

while (i < arr.Length)
{
    arr[i] = i + 1;
    Console.Write(arr[i] + " ");
    i = i + 1;
}