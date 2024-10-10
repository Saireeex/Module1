using System;

class GuessTheNumber
{
    static void Main()
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 101);
        int userGuess = 0;
        int attempts = 0;

        Console.WriteLine("Загадано число от 1 до 100. Угадайте это число!");

        while (userGuess != numberToGuess)
        {
            Console.Write("Введите ваше предположение: ");
            string input = Console.ReadLine();

            // Проверка на ввод корректного числа
            if (int.TryParse(input, out userGuess))
            {
                attempts++;

                if (userGuess < 1 || userGuess > 100)
                {
                    Console.WriteLine("Пожалуйста, введите число в диапазоне от 1 до 100.");
                }
                else if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
                else
                {
                    Console.WriteLine($"Вы угадали число {numberToGuess} за {attempts} попыток.");
                }
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное целое число.");
            }
        }
    }
}