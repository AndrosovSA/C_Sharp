// Программа которая считает сколько гласных в строке

int CountVowels(string str)
{
    string vowels = "eyuoai";
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if(str[i] == vowels[j]) count++;
        }
    }
    return count;
}
Console.WriteLine("Введите строку латинских маленьких букв: ");
string? str = Console.ReadLine();
int result = CountVowels(str);
Console.Write("Количество гласных: ");
Console.Write(result);