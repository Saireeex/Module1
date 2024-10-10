using System;

class AverageCalculator
{
    static void Main()
    {
        Console.WriteLine("Введите три числа для вычисления их среднего арифметического:");

        // Ввод первого числа
        Console.Write("Первое число: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        // Ввод второго числа
        Console.Write("Второе число: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        // Ввод третьего числа
        Console.Write("Третье число: ");
        double thirdNumber = Convert.ToDouble(Console.ReadLine());

        // Вычисление среднего арифметического
        double average = (firstNumber + secondNumber + thirdNumber) / 3;

        // Вывод результата
        Console.WriteLine($"Среднее арифметическое: {average}");
    }
}