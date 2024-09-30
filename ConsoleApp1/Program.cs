using System;

class Program
{
    static void Main(string[] args)
    {
        // Запрос фамилии
        Console.Write("Введите фамилию: ");
        string lastName = Console.ReadLine();

        // Запрос имени
        Console.Write("Введите имя: ");
        string firstName = Console.ReadLine();

        // Запрос отчества
        Console.Write("Введите отчество: ");
        string patronymic = Console.ReadLine();

        // Отображение ФИО в одну строку
        Console.WriteLine($"{lastName} {firstName} {patronymic}");
    }
}
