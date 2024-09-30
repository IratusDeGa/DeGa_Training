using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];
        int sum = 0; // определим переменную для хранения суммы

        Console.WriteLine("Пожалуйста, введите 5 цифр:");

        for (int i = 0; i < 5; i++)
        {
            bool validInput = false;
            while (!validInput)
            {
                try
                {
                    Console.Write($"Введите цифру {i + 1}: ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input))
                    {
                        throw new ArgumentException("Ввод не может быть пустым.");
                    }

                    numbers[i] = int.Parse(input);

                    if (numbers[i] < 0 || numbers[i] > 9)
                    {
                        throw new ArgumentOutOfRangeException("Введите цифру от 0 до 9.");
                    }

                    sum += numbers[i]; // проходя каждый элемент массива, прибавим его к сумме
                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введите целое число!");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
                }
            }
        }

        double average = (double)sum / numbers.Length;
        Console.WriteLine($"\nСреднее арифметическое введенных чисел: {average:F2}"); // \n - вставка новой строки
    }
}

//Пользователю предлагается ввести 5 цифр.
//Используем массив numbers для хранения входных цифр по порядку.
//Реализуем обработку ошибок с использованием блоков try-catch для обработки различных возможных ошибок:
    //исключение FormatException: если входные данные не являются допустимым целым числом.
    //исключение ArgumentOutOfRangeException: Если на входе нет ни одной цифры (0-9).
    //исключение ArgumentException: если входные данные пусты или null.
    //общий перехват исключений для любых непредвиденных ошибок.
//Вычисляем и отображаем среднее арифметическое (average) всех введенных чисел.
//Программа будет продолжать запрашивать ввод для каждой позиции, пока не будет введена допустимая цифра.
//Это гарантирует, что массив всегда будет заполнен 5 допустимыми цифрами перед вычислением среднего значения.

//Среднее значение отображается с двумя знаками после запятой (:F2).