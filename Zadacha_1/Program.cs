﻿class Program
{
    static void Main()
    {
        while (true)
        {
            // Запрашиваем у пользователя ввод целого числа или 'q' для завершения программы.
            Console.WriteLine("Введите целое число. Для завершения введите 'q' или четное чисто:");
            string input = Console.ReadLine()!;

            // Проверяем, если пользователь ввел 'q', завершаем программу.
            if (input.ToLower() == "q")
            {
                Console.WriteLine("Вы ввели 'q', программа завершена");
                break;
            }

            // Пытаемся преобразовать введенную строку в целое число.
            if (int.TryParse(input, out int number))
            {
                // Вычисляем сумму цифр введенного числа.
                int digitSum = CDS(number);

                // Проверяем, является ли сумма цифр четной.
                if (digitSum % 2 == 0)
                {
                    Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершается.");
                    break;
                }
                else
                {
                    Console.WriteLine("Продолжайте ввод.");
                }
            }
            else
            {
                // Выводим сообщение об ошибке при некорректном вводе.
                Console.WriteLine("Некорректный ввод.");
            }
        }
    }

    // Метод для вычисления суммы цифр числа.
    static int CDS(int num) // CDS = CalculateDigitSum
    {
        int sum = 0;
        while (num != 0)
        {
            sum += num % 10; // Получаем последнюю цифру числа и добавляем её к сумме.
            num /= 10; // Удаляем последнюю цифру из числа.
        }
        return sum;
    }
}