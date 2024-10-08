using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер простого числа: ");
        int n = int.Parse(Console.ReadLine());

        int primeNumber = FindNSimple(n);
        Console.WriteLine($"Простое число под номером {n} - это {primeNumber}");
    }

    static int FindNSimple(int n)
    {
        if (n < 1) throw new ArgumentException("n должно быть больше 0");

        int count = 0; // Счетчик найденных простых чисел
        int number = 1; // Текущее число для проверки

        while (count < n)
        {
            number++;
            if (IsSimple(number))
            {
                count++;
            }
        }

        return number;
    }

    static bool IsSimple(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true; // 2 - простое число
        if (num % 2 == 0) return false; // исключаем четные числа

        for (int i = 3; i <= Math.Sqrt(num); i += 2)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}


//Программа запрашивает у пользователя номер простого числа
//Функция FindNSimple ищет n-е простое число, начиная с 1 и увеличивая число на 1, пока не найдет нужное количество простых чисел
//Функция IsSimple проверяет, является ли число простым, используя стандартный алгоритм проверки делимости
//Результат выводится на экран