// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumRec(int m, int n)
{
    if (m<=n) return n + SumRec(m,n-1);
    else return 0;
}

System.Console.Write("Enter M = ");
int M = int.Parse(System.Console.ReadLine()!);
System.Console.Write("Enter N = ");
int N = int.Parse(System.Console.ReadLine()!);
System.Console.WriteLine(SumRec(M,N));
