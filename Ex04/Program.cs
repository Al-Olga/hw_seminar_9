// Написать программу показывающие первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем
int sum_elem (int a, int b)
{
    int sum=a+b;
    return sum;
}

void EnterArray (int[] array)
{
    for (int i=2; i<array.Length; i++)
        array[i]=sum_elem(array[i-2], array[i-1]); 
}

void PrintArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

Console.Write("Введите первое число последовательности: ");
int first = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число последовательности: ");
int second = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество вычисляемых элементов последовательности: ");
int number = int.Parse(Console.ReadLine() ?? "0");

int[] array_numb = new int[number+2];
array_numb[0]=first;
array_numb[1]=second;

EnterArray (array_numb);
PrintArray (array_numb);
