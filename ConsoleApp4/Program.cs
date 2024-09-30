using System;

class UserCatalog
{
    static void Main()
    {
        // Создаем 2D-массив для хранения данных о 3-х пользователях
        string[,] users = new string[3, 3];

        // Собираем данные о пользователях
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Введите данные для пользователя {i + 1}:");

            Console.Write("Фамилия: ");
            users[i, 0] = Console.ReadLine();

            Console.Write("Имя: ");
            users[i, 1] = Console.ReadLine();

            Console.Write("Должность: ");
            users[i, 2] = Console.ReadLine();
        }

        // Запрос о каком пользователе выдать информацию
        Console.WriteLine("Введите номер пользователя (1-3), чтобы получить информацию о нем:");
        int userNumber = int.Parse(Console.ReadLine()) - 1;

        if (userNumber >= 0 && userNumber < 3)
        {
            Console.WriteLine("Информация о пользователе:");
            Console.WriteLine($"Фамилия: {users[userNumber, 0]}");
            Console.WriteLine($"Имя: {users[userNumber, 1]}");
            Console.WriteLine($"Должность: {users[userNumber, 2]}");
        }
        else
        {
            Console.WriteLine("Неверный номер пользователя.");
        }
    }
}


//Программа использует 2D-массив "users" для хранения информации о трех пользователях. У каждого пользователя есть три элемента информации: фамилия, отчество и должность.
//Цикл используется для сбора данных по каждому пользователю.
//После сбора данных программа предлагает пользователю ввести номер, соответствующий пользователю, информацию о котором он хочет просмотреть.
//Затем он отображает информацию для выбранного пользователя, если входные данные верны
