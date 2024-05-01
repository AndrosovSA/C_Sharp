// Программа выводит в строку только латинские буквы
// string? GetLettersFromString(string str)
// {
//     string letters = "";
//     foreach(char e in str)
//     {
//         if(char.IsAsciiLetter(e) == true) letters = letters + e;
//     }
//     return letters;
// }
// string? str = Console.ReadLine();
// string? resultString = GetLettersFromString(str);
// Console.WriteLine(resultString);

// Создание строки из повторяющихся символов
// string str = new string('Q', 10);
// Console.WriteLine(str);

// Создание строки из массива которая из массива делает строку
// char[] chars = new char[] {'A', 'B', 'C', 'D'};
// string str = new string(chars);
// Console.WriteLine(str);

// Создание массива символов из строки
// string str = "Привет, я строка";
// char[] charsArray = str.ToCharArray();
// void PrintArray(char[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.Write("]");
// }
// PrintArray(charsArray);

// Создание массива слов из строки
// string str = "Привет, я строка";
// string[] wordArray = str.Split();
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}
// string[] NewString(string[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if 
//     }
// }


Console.Write("Введите набор строк через пробел используя латинский алфавит и небуквенные символы: ");
string? str = Console.ReadLine();
string[] wordArray = str.Split();
PrintArray(wordArray);




