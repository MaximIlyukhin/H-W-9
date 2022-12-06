// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NumbresRec(int a, int b)
{
    if (a <= b) return NumbresRec(a + 1, b) + $"{a} ";
    else return String.Empty;
}
System.Console.Write("Enter N = ");
int N = int.Parse(System.Console.ReadLine()!);
System.Console.WriteLine(NumbresRec(1, N));