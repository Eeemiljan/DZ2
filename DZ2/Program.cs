using System;

enum University
{
    КГУ,
    КАИ,
    КХТИ
}

struct Worker
{
    public string Name;
    public University UniversityName;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Домашнее задание 3.1. Работник и ВУЗ");

        Worker worker = new Worker();

        Console.Write("Введите имя работника: ");
        worker.Name = Console.ReadLine();

        worker.UniversityName = University.КГУ;

        Console.WriteLine($"Имя: {worker.Name}");
        Console.WriteLine($"ВУЗ: {worker.UniversityName}");
    }
}
