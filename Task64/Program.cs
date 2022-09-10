// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void ShowNumsNM(int n, int m)
{
    if (m > n)
    {
        int temp = n;
        n = m;
        m = temp;
    }
    if (n != m) ShowNumsNM(n - 1, m);
    Console.Write(n + " ");
}
Console.Write("Input number M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int numN = Convert.ToInt32(Console.ReadLine());

ShowNumsNM(numN, numM);
