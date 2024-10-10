using System;

class SubstringChecker
{
    static void Main()
    {
        Console.Write("Введите первую строку: ");
        string firstString = Console.ReadLine();

        Console.Write("Введите вторую строку: ");
        string secondString = Console.ReadLine();

        if (firstString.Contains(secondString))
        {
            Console.WriteLine($"Вторая строка \"{secondString}\" является подстрокой первой строки.");
        }
        else
        {
            Console.WriteLine($"Вторая строка \"{secondString}\" не является подстрокой первой строки.");
        }
    }
}