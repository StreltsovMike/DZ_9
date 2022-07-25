// Задайте значения M и N. Напишите программу, 
// которая выведет все НАТУРАЛЬНЫЕ числа в промежутке от M до N.

string PrintNumbersToConsole(int N, int M)
{
    if (N == M) return N.ToString();
    return (N + ", " + PrintNumbersToConsole(N + 1, M));

}

Console.WriteLine("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 0) N = 0;                             //Чтобы программа выводила только натуральные числа 
                                              // отделим отрицательную часть

Console.WriteLine("Введите M:");
int M = Convert.ToInt32(Console.ReadLine());
if (M < 0) M = 0;

if (M >= N)
    Console.WriteLine(PrintNumbersToConsole(N, M));

else
    Console.WriteLine(PrintNumbersToConsole(M, N));