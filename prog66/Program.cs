/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.WriteLine("Введите M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N");
 int n = Convert.ToInt32(Console.ReadLine());
int temp = m;
Console.Write($"Сумма в промежутке от {m} до  {n} равна : ");
CalculateSummAndPrint(m, n, temp = 0);

void CalculateSummAndPrint(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($" {sum} ");
        return;
    }
    CalculateSummAndPrint(m, n - 1, sum);

}
