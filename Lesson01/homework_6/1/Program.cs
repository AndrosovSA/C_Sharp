// Программа меняет большие буквы на маленькие
// 1 способ
// string? str = Console.ReadLine();
// str = str.ToLower();
// Console.WriteLine(str);


// 2 способ
string stringToLower(string str)
{
    string letters = string.Empty;
    for (int i = 0; i < str.Length; i++)
    {
        if (char.IsUpper(str[i]))
        {
            letters = letters + str[i].ToString().ToLower();
        }
        else
        {
            letters = letters + str[i];
        }
    }
    return letters;
}
Console.WriteLine("Введите строку используя верхний и нижний регистры");
string? str = Console.ReadLine();
string? result = stringToLower(str);
Console.WriteLine(result);