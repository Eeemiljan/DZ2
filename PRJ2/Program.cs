using System;

enum Category
{
    a,
    b,
    c,
    d
}

struct Drink
{
    public string Name;
    public double Percent;
}

struct Student
{
    public string LastName;
    public string FirstName;
    public int Id;
    public string Birthday;
    public Category Category;
    public double Volume;
    public Drink DrinkInfo;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Проект. Шесть задач");
        Console.WriteLine("1 - Типы данных");
        Console.WriteLine("2 - Информация о пользователе");
        Console.WriteLine("3 - Регистр букв");
        Console.WriteLine("4 - Поиск подстроки");
        Console.WriteLine("5 - Duty Free");
        Console.WriteLine("6 - Студенты");

        Console.Write("Введите номер задачи: ");
        string number = Console.ReadLine();

        if (number == "1")
        {
            Console.WriteLine("Задача 1. Границы типов данных");
            Console.WriteLine("Ввод не требуется");
            Console.WriteLine("Тип - максимум - минимум");

            Console.WriteLine($"byte - {byte.MaxValue} - {byte.MinValue}");
            Console.WriteLine($"sbyte - {sbyte.MaxValue} - {sbyte.MinValue}");
            Console.WriteLine($"short - {short.MaxValue} - {short.MinValue}");
            Console.WriteLine($"ushort - {ushort.MaxValue} - {ushort.MinValue}");
            Console.WriteLine($"int - {int.MaxValue} - {int.MinValue}");
            Console.WriteLine($"uint - {uint.MaxValue} - {uint.MinValue}");
            Console.WriteLine($"long - {long.MaxValue} - {long.MinValue}");
            Console.WriteLine($"ulong - {ulong.MaxValue} - {ulong.MinValue}");
            Console.WriteLine($"float - {float.MaxValue} - {float.MinValue}");
            Console.WriteLine($"double - {double.MaxValue} - {double.MinValue}");
            Console.WriteLine($"decimal - {decimal.MaxValue} - {decimal.MinValue}");
            Console.WriteLine($"char - {(int)char.MaxValue} - {(int)char.MinValue}");

            Console.WriteLine("bool - true или false");
            Console.WriteLine("string - нет числового максимума и минимума");
            Console.WriteLine("object - нет числового максимума и минимума");
        }
        else if (number == "2")
        {
            Console.WriteLine("Задача 2. Информация о пользователе");

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите город: ");
            string city = Console.ReadLine();

            Console.Write("Введите возраст целым числом: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Введите учебный PIN-код: ");
            string pin = Console.ReadLine();

            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Город: {city}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"PIN-код: {pin}");
        }
        else if (number == "3")
        {
            Console.WriteLine("Задача 3. Поменять регистр букв");

            Console.Write("Введите строку: ");
            string text = Console.ReadLine();

            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];

                if (char.IsUpper(letter))
                {
                    result += char.ToLower(letter);
                }
                else
                {
                    result += char.ToUpper(letter);
                }
            }

            Console.WriteLine($"Результат: {result}");
        }
        else if (number == "4")
        {
            Console.WriteLine("Задача 4. Количество вхождений подстроки");
            Console.WriteLine("Регистр учитывается, пересечения считаются.");

            Console.Write("Введите строку: ");
            string text = Console.ReadLine();

            Console.Write("Введите подстроку: ");
            string part = Console.ReadLine();

            if (part.Length == 0)
            {
                Console.WriteLine("Подстрока не должна быть пустой");
                return;
            }

            int count = 0;

            for (int i = 0; i <= text.Length - part.Length; i++)
            {
                bool found = true;

                for (int j = 0; j < part.Length; j++)
                {
                    if (text[i + j] != part[j])
                    {
                        found = false;
                    }
                }

                if (found)
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество вхождений: {count}");
        }
        else if (number == "5")
        {
            Console.WriteLine("Задача 5. Duty Free");
            Console.WriteLine("Введите три целых числа.");

            Console.Write("Обычная цена бутылки: ");
            int normPrice = int.Parse(Console.ReadLine());

            Console.Write("Скидка в процентах: ");
            int salePrice = int.Parse(Console.ReadLine());

            Console.Write("Стоимость отпуска: ");
            int holidayPrice = int.Parse(Console.ReadLine());

            if (normPrice <= 0 || salePrice <= 0 ||
                salePrice > 100 || holidayPrice < 0)
            {
                Console.WriteLine("Неверные данные");
                return;
            }

            decimal saving = (decimal)normPrice * salePrice / 100;
            long count = (long)(holidayPrice / saving);

            Console.WriteLine($"Количество бутылок: {count}");
        }
        else if (number == "6")
        {
            Console.WriteLine("Задача 6. Студенты");
            Console.WriteLine("Данные заданы в коде. Ввод не требуется.");
            Console.WriteLine("Все объёмы указаны в литрах.");

            Drink drink = new Drink();
            drink.Name = "Мохито";
            drink.Percent = 15;

            Student[] students = new Student[5];

            students[0].LastName = "Арбузов";
            students[0].FirstName = "Миша";
            students[0].Id = 676767;
            students[0].Birthday = "14.03.2005";
            students[0].Category = Category.a;
            students[0].Volume = 5;
            students[0].DrinkInfo = drink;

            students[1].LastName = "Дыньков";
            students[1].FirstName = "Саша";
            students[1].Id = 525252;
            students[1].Birthday = "22.07.2005";
            students[1].Category = Category.d;
            students[1].Volume = 0;
            students[1].DrinkInfo = drink;

            students[2].LastName = "Путинов";
            students[2].FirstName = "Артем";
            students[2].Id = 777777;
            students[2].Birthday = "05.11.2004";
            students[2].Category = Category.a;
            students[2].Volume = 4;
            students[2].DrinkInfo = drink;

            students[3].LastName = "Абрикосов";
            students[3].FirstName = "Дима";
            students[3].Id = 102102;
            students[3].Birthday = "18.01.2005";
            students[3].Category = Category.c;
            students[3].Volume = 0.4;
            students[3].DrinkInfo = drink;

            students[4].LastName = "Бутербродов";
            students[4].FirstName = "Женя";
            students[4].Id = 123456;
            students[4].Birthday = "09.09.2004";
            students[4].Category = Category.b;
            students[4].Volume = 1;
            students[4].DrinkInfo = drink;

            double totalLiquid = 0;
            double totalAlcohol = 0;

            for (int i = 0; i < students.Length; i++)
            {
                totalLiquid += students[i].Volume;

                totalAlcohol += students[i].Volume *
                    students[i].DrinkInfo.Percent / 100;
            }

            Console.WriteLine($"Всего жидкости: {totalLiquid} л");
            Console.WriteLine($"Всего чистого спирта: {totalAlcohol} л");

            double averagePercent = 0;

            if (totalLiquid > 0)
            {
                averagePercent = totalAlcohol / totalLiquid * 100;
            }

            Console.WriteLine($"Общая доля спирта: {averagePercent}%");

            for (int i = 0; i < students.Length; i++)
            {
                double alcohol = students[i].Volume *
                    students[i].DrinkInfo.Percent / 100;

                double liquidPercent = 0;
                double alcoholPercent = 0;

                if (totalLiquid > 0)
                {
                    liquidPercent = students[i].Volume / totalLiquid * 100;
                }

                if (totalAlcohol > 0)
                {
                    alcoholPercent = alcohol / totalAlcohol * 100;
                }

                Console.WriteLine();
                Console.WriteLine($"{students[i].LastName} {students[i].FirstName}");
                Console.WriteLine($"ID: {students[i].Id}");
                Console.WriteLine($"Дата рождения: {students[i].Birthday}");
                Console.WriteLine($"Категория: {students[i].Category}");
                Console.WriteLine($"Напиток: {students[i].DrinkInfo.Name}");
                Console.WriteLine($"Крепость: {students[i].DrinkInfo.Percent}%");
                Console.WriteLine($"Выпито жидкости: {students[i].Volume} л");
                Console.WriteLine($"Выпито чистого спирта: {alcohol} л");
                Console.WriteLine($"Доля от всей жидкости: {liquidPercent}%");
                Console.WriteLine($"Доля от всего спирта: {alcoholPercent}%");
            }
        }
        else
        {
            Console.WriteLine("Неверный номер задачи");
        }
    }
}
