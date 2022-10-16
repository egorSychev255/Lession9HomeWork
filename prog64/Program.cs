/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.*/
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