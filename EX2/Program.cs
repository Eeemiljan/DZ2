using System;

enum BankAccountType
{
    Current,
    Savings
}

struct BankAccount
{
    public string Number;
    public BankAccountType Type;
    public decimal Balance;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Упражнение 3.1. Виды банковского счёта");

        BankAccountType type = BankAccountType.Current;

        Console.WriteLine($"Тип счёта: {type}");

        Console.WriteLine();
        Console.WriteLine("Упражнение 3.2. Информация о банковском счёте");

        BankAccount account = new BankAccount();

        account.Number = "123456";
        account.Type = BankAccountType.Current;
        account.Balance = 15000m;

        Console.WriteLine($"Номер счёта: {account.Number}");
        Console.WriteLine($"Тип счёта: {account.Type}");
        Console.WriteLine($"Баланс: {account.Balance}");
    }
}
