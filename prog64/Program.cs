Console.WriteLine("ВВедите N");
int UserNumber = Convert.ToInt32(Console.ReadLine());
WriteNumbers(UserNumber);

void WriteNumbers(int n)
{
    if (n > 0)
    {
        Console.Write($"{n},");
        WriteNumbers(n - 1);
    }
}   