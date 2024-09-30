using System;

class Program
{
    static void Main()
    {
        // Запрос первого значения
        Console.Write("Введите первое значение: ");
        double firstValue = Convert.ToDouble(Console.ReadLine());

        // Запрос второго значения
        Console.Write("Введите второе значение: ");
        double secondValue = Convert.ToDouble(Console.ReadLine());

        // Запрос действия
        Console.Write("Введите действие (+, -, *, /): ");
        string operation = Console.ReadLine();

        double result;

        // Выполнение операции в зависимости от введенного действия
        switch (operation)
        {
            case "+":
                result = firstValue + secondValue;
                break;
            case "-":
                result = firstValue - secondValue;
                break;
            case "*":
                result = firstValue * secondValue;
                break;
            case "/":
                if (secondValue != 0)
                {
                    result = firstValue / secondValue;
                }
                else
                {
                    Console.WriteLine("Ошибка: деление на ноль!");
                    return;
                }
                break;
            default:
                Console.WriteLine("Ошибка: неверное действие!");
                return;
        }

        // Вывод результата
        Console.WriteLine($"Результат операции: {result}");
    }
}
