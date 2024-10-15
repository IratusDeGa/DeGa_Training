using System;
using System.IO;

class Program
{
    static void Main()
    {
        string directoryPath = "Заметки";
        Directory.CreateDirectory(directoryPath);

        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Записать в новый файл");
            Console.WriteLine("2. Открыть и дописать в существующий файл");
            Console.WriteLine("3. Выход");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Введите имя файла: ");
                string fileName = Console.ReadLine();
                string filePath = Path.Combine(directoryPath, fileName);

                Console.WriteLine("Введите текст (для завершения введите 'exit'):");
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    string input;
                    while ((input = Console.ReadLine()) != "exit")
                    {
                        writer.WriteLine(input);
                    }
                }
            }
            else if (choice == "2")
            {
                string[] files = Directory.GetFiles(directoryPath);
                Console.WriteLine("Выберите файл для редактирования:");
                for (int i = 0; i < files.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {Path.GetFileName(files[i])}");
                }

                int fileChoice = int.Parse(Console.ReadLine()) - 1;
                string selectedFile = files[fileChoice];

                Console.WriteLine("Введите текст (для завершения введите 'exit'):");
                using (StreamWriter writer = new StreamWriter(selectedFile, true))
                {
                    string input;
                    while ((input = Console.ReadLine()) != "exit")
                    {
                        writer.WriteLine(input);
                    }
                }
            }
            else if (choice == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Неверный выбор, попробуйте снова.");
            }
        }
    }
}

