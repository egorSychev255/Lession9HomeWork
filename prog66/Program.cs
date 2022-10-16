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
