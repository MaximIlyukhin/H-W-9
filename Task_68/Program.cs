// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// A(0,n) = n + 1;
// A(1,n) = n + 2; n+m-1
// A(2,n) = n + 3;
// A(3,n) = 2**(n+3) - 3;

double Ackerman(int m, int n)
{
    if (m == 1 || m == 0) return n + m + 1;
    else if (m == 2) return n * m + m + 1;
    else return Math.Pow(2, n + m) - m;
}
System.Console.Write("Enter m = ");
int m = int.Parse(System.Console.ReadLine()!);
System.Console.Write("Enter n = ");
int n = int.Parse(System.Console.ReadLine()!);
System.Console.WriteLine(Ackerman(m, n));