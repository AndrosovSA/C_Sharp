
// double CalculateFormula(int a, int b, int c, int d)
// {
//     double numerator = a * b;
//     double denominator = c + d;
//     double result = numerator / denominator;

//     return result;
// }
// double result = CalculateFormula(4, 2, 1, 1);
// Console.Write(result);


void PrintSquaers(int limit)
{
    int i = 1;
    while (i < limit)
    {
        Console.Write($"{i * i} ");
        i++;
    }
}
PrintSquaers(5);
Console.WriteLine();
PrintSquaers(10);
Console.WriteLine();
PrintSquaers(25);