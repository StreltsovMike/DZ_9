// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму НАТУРАЛЬНЫХ элементов в промежутке от M до N.

int SumBetweenNM(int N, int M)
{
    if (N == M) return N;
    return (N + SumBetweenNM(N + 1, M));
}

Console.WriteLine("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 0) N = 0;                             //Чтобы программа выводила сумму только натуральных чисел 
                                              // отделим отрицательную часть             

Console.WriteLine("Введите M:");
int M = Convert.ToInt32(Console.ReadLine());
if (M < 0) M = 0;

if (M >= N)
    Console.WriteLine(SumBetweenNM(N, M));
else
    Console.WriteLine(SumBetweenNM(M, N));