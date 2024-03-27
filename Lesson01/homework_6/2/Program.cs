// программа определяет является ли строка полиндромом

string reversString(string str)
{
    string rvrStr = string.Empty;
    for (int i = 0; i < str.Length; i++)
    {
        rvrStr = rvrStr + str[str.Length - 1 - i];
    }
    return rvrStr;
}
void IsPolydrome(string s1, string s2)
{
    for (int i = 0; i < s1.Length; i++)
    {
        if (s1[i] != s2[i])
        {
            Console.Write("=> НЕT");
            return;
        }
    }
    Console.Write("=> ДА");
}

Console.WriteLine("Введите строку");
string? str = Console.ReadLine();
// string str = "шашлык"; // при вводе с консоли кирилица не распознается
string? result = reversString(str);
Console.Write($"{result} ");
IsPolydrome(str, result);