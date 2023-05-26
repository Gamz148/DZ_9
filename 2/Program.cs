/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

void Main()
{
    Console.WriteLine("Введите значение M:");
    int m = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение N:");
    int n = int.Parse(Console.ReadLine());

    int sum = CalculateSum(m, n);
    Console.WriteLine("Сумма натуральных чисел от M до N: " + sum);
}

int CalculateSum(int m, int n)
{
    if (m > n)
        return 0;

    return m + CalculateSum(m + 1, n);
}

Main();