// Cчитать строку с консоли, содержащую латинские буквы. Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l “World” => W r l d

void printConsonantsFromString(string str)
{
    if (str.Length == 0) return;
    string chars = "eyuoai";
    if (char.IsAsciiLetter(str[0]) && !chars.Contains(str[0]))
    Console.Write($"{str[0]} ");
printConsonantsFromString(str.Substring(1));
}
Console.Write("Введите строку: ");
string str = Console.ReadLine();
printConsonantsFromString(str);