/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/


void Main()
{
    Console.WriteLine("Введите значение m:");
    int m = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение n:");
    int n = int.Parse(Console.ReadLine());

    int result = AckermanFunction(m, n);
    Console.WriteLine($"Результат функции Аккермана для {m} и {n} = {result}");

}

int AckermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return AckermanFunction(m - 1, 1);
    else
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

Main();
