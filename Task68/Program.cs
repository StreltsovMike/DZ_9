// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.



int Akkerman(int N, int M)
{
    if (N == 0) return M + 1;
    if (N > 0 && M == 0) return (Akkerman(N - 1, 1));
    return (Akkerman(N - 1, Akkerman(N, M - 1)));
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());


if (N>=0 && M>=0)
Console.WriteLine(Akkerman(N, M));

else
Console.WriteLine("Числа должны быть натураньными");