using System;

enum BankAccountType
{
    Current,
    Savings
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Упражнение 3.1. Виды банковского счёта");

        BankAccountType type = BankAccountType.Current;

        Console.WriteLine($"Тип счёта: {type}");
    }
}
