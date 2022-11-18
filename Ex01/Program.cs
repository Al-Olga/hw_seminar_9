// Показать натуральные числа от M до N, N и M заданы
// Найти сумму элементов от M до N, N и M заданы

double SumElem (int [] array) 
{
    double sum=0;
    for (int i=0; i<array.Length; i++) 
        sum=sum+array[i];
    return sum;
}

//заполняем массив натуральных чисел с заданным диапазоном
void EnterArray (int[] array, int min)
{
    for (int i=0; i<array.Length; i++)
        array[i]=min+i; 
}

void PrintArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

Console.Write("Введите начальное число для диапазона натуральных чисел: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите конечное число для диапазона натуральных чисел: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int min=0;
int max=0;
int kol_numb;
if (m>n)
{
    min=n;
    max=m;    
}
else if (m<n)
{
    min=m;
    max=n;
}
kol_numb=max-min;
if (kol_numb!=0)
{
    int[] array_numb = new int[kol_numb+1];
    EnterArray (array_numb, min);
    Console.Write("Натуральный ряд: ");
    PrintArray (array_numb);
    Console.WriteLine($"Сумма элементов = {SumElem (array_numb)}");    
}
else 
{
    Console.WriteLine("Задан неверный диапазон для ряда натуральных чисел");    
    Console.WriteLine($"Сумма элементов = {m}");
}
