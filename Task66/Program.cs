// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

int SumNM(int m, int n)
{
    if (m > n)
    {
        int temp = m;
        m = n;
        n = temp;
    }
    if (n != m) return n + SumNM(m, n - 1);
    return n;
}

Console.Write("Input number M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int numN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма натуральных чисел от {numM} до {numN} =  {SumNM(numM, numN)}");
