// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
void ShowNto1 (int N)
{
if (N==1) Console.WriteLine(1);
    else 
    {
        Console.Write($"{N}, ");
        ShowNto1(N-1);
    }
}
// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumMtoN (int M, int N)
{
if (N==M+1) return N+M;
    else return N+SumMtoN(M,N-1);
}
// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
ulong Ackermann(ulong m, ulong n)
{
    if (m==0)
    return n+1;
        else if (n==0)
        return Ackermann(m-1, 1);
            else 
            return Ackermann(m-1, Ackermann(m,n-1));
}   
Console.WriteLine("Введите номер решаемой задачи (64,66,68)");
int taskNumber = int.Parse(Console.ReadLine());
if (taskNumber==64)
{
    Console.WriteLine("Задача 64");
    Console.WriteLine("Введите число N для задачи 64");
    int N64 = int.Parse(Console.ReadLine());
    Console.Write($"Натуральные числа в промежутке от {N64} до 1: "); 
    ShowNto1 (N64);
}
else if (taskNumber==66)
{
    Console.WriteLine("Задача 66");
    Console.WriteLine("Введите число M для задачи 66");
    int M66 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число N для задачи 66");
    int N66 = int.Parse(Console.ReadLine());
    if (N66==M66)
    Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {M66+N66}");
        else if (N66>M66)
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {SumMtoN (M66,N66)}");
            else
            Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {SumMtoN (N66,M66)}");    
}
else if (taskNumber==68)
{
    Console.WriteLine("Задача 66");
    Console.WriteLine("Введите число m для задачи 68");
    ulong m68 = ulong.Parse(Console.ReadLine());
    Console.WriteLine("Введите число n для задачи 68");
    ulong n68 = ulong.Parse(Console.ReadLine());   
    Console.WriteLine($"Значение функции Аккермана A(m,n) при m = {m68} и n = {n68}: {Ackermann(m68, n68)}");
}
else
Console.WriteLine("Не был введён корректный номер задачи.");