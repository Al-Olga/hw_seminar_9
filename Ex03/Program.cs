// Написать программу возведения числа А в целую стень B

double Stepen (int number, int stepen)
{
    double st=number;
    if (stepen==0) st=1;
    else if (stepen>0)
        for (int i=1; i<stepen; i++)
            st=st*number;
    else
    {
        stepen=stepen*(-1);
        for (int i=1; i<stepen; i++)
            st=st*number;
        st=1/st;
    }
    return st;
}

Console.Write("Введите число, степень которого надо найти: ");
int numb = int.Parse(Console.ReadLine() ?? "0");
Console.Write($"Введите степень, в которую надо возвести число {numb}: ");
int step = int.Parse(Console.ReadLine() ?? "0");
if ((numb==0) & (step==0)) Console.Write("задача не имеет смысла");
else Console.WriteLine($"Число {numb} в степени {step} = {Stepen (numb, step)}");
Console.WriteLine("");
