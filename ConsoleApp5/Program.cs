using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); //  коллекция - аналог типизированного массива, который может динамически расширяться
        int errorCount = 0;
        bool continueProgram = true;

        while (continueProgram)
        {
            while (true)
            {
                Console.WriteLine("Введите число или 'Q' для завершения ввода:");
                string input = Console.ReadLine();

                if (input.ToUpper() == "Q") // приводим к верхнему регистру
                    break;

                if (int.TryParse(input, out int number)) // вызов метода преобразования строки в число
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Ошибка: Введено некорректное значение. Пожалуйста, введите число или 'Q'.");
                    errorCount++;
                }
            }

            Console.WriteLine("Введенные числа:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            while (true)
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Очистить");
                Console.WriteLine("2. Продолжить");
                Console.WriteLine("3. Выйти");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    numbers.Clear();
                    Console.WriteLine("Массив очищен.");
                    break;
                }
                else if (choice == "2")
                {
                    break;
                }
                else if (choice == "3")
                {
                    continueProgram = false;
                    Console.WriteLine($"Программа завершена. Введено элементов: {numbers.Count}, Количество ошибок: {errorCount}");
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный выбор. Пожалуйста, выберите 1, 2 или 3.");
                }
            }
        }
    }
}



//Для хранения чисел используется List<int>, который автоматически обрабатывает изменение размера при добавлении новых элементов.
//Программа непрерывно запрашивает у пользователя вводимые данные до тех пор, пока не будет введено 'Q'.
//Если введено недопустимое число, он отображает сообщение об ошибке и продолжает запрашивать ввод.
//После ввода 'Q' отображаются все введенные числа.
//Затем спрашиваем пользователя, что он хочет делать дальше: Очистить, Продолжить или Выйти.
//Если выбрано "Очистить", очищаем список и снова спрашиваем, что делать.
//Если выбрано "Продолжить", возвращаемся к запросу чисел.
//Если выбрано "Exit", программа завершает работу и отображает количество введенных элементов и количество допущенных ошибок.
//Также программа отслеживает количество ошибок при вводе неверных входных данных.
