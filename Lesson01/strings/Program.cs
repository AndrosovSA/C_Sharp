// Строки
string GetLettersFromString(string str)
{
    string letters = "";
    foreach(char e in str)
    {
        if(char.IsAsciiLetter(e) == true) letters = letters + e;
    }
    return letters;
}
string str = Console.ReadLine();
string resultString = GetLettersFromString(str);
Console.WriteLine(resultString);