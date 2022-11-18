// Написать программу вычисления функции Аккермана

double FunAkkermana(int n, double m)
{
    if (n==0)
        return m+1;
    else if ((n!=0) && (m==0))
        return FunAkkermana(n-1, 1);
    else
        return FunAkkermana(n-1, FunAkkermana(n, m-1));
}

Console.WriteLine("Введите значения n и m для функции Аккермана: ");
Console.Write("n= ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("m= ");
int m = int.Parse(Console.ReadLine() ?? "0");
if ((n>=0) & (m>=0))
    Console.WriteLine($"Результат вычисления функции Аккермана= {FunAkkermana(n, m)}");
else 
    Console.WriteLine
    ("n и m должны быть неотрицательные целые числа." + 
    " При значениях n >= 4 может и больших значениях m может возникнуть переполнение стека");
