// Программа переставляет слова в предложении с первого на последнее и далее соответсвенно

string[] creatArrayFromString(string str)
{
    string[] tableWord = null;
    tableWord = str.Split();
    return tableWord;
}
string[] reversArray(string[] array)
{
    string temp = string.Empty;
    for (int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
}
void printArray(string[] array)
{
    foreach (string word  in array)
    {
        Console.Write($"{word} ");
    }
}
Console.WriteLine("Введите текст на английском: ");
string str = Console.ReadLine();
string[] array = creatArrayFromString(str);
string[] arrayResult = reversArray(array);
printArray(arrayResult);