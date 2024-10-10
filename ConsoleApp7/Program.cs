using System;

class Program
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int player = 1; // 1 = X, 2 = O
    static int choice; // Пользовательский выбор
    static int flag = 0; // Флаг для проверки победы

    static void Main(string[] args)
    {
        do
        {
            Console.Clear();
            Console.WriteLine("Игрок 1: X и Игрок 2: O");
            Console.WriteLine("\n");
            Board();

            // Проверка на победу
            flag = CheckWin();

            if (flag == 1)
            {
                Console.WriteLine("Игрок 1 победил!");
                break;
            }
            else if (flag == 2)
            {
                Console.WriteLine("Игрок 2 победил!");
                break;
            }

            // Переключение игроков
            player = (player % 2) + 1;

            // Ввод выбора
            Console.WriteLine("\n");
            Console.WriteLine($"Игрок {player}, выберите номер от 1 до 9:");
            choice = Convert.ToInt32(Console.ReadLine()) - 1;

            // Проверка на занятость
            if (board[choice] != 'X' && board[choice] != 'O')
            {
                board[choice] = (player == 1) ? 'X' : 'O';
            }
            else
            {
                Console.WriteLine("Эта клетка уже занята!");
                player--;
                Console.ReadLine();
            }

        } while (flag != 1 && flag != 2);

        Console.WriteLine("Нажмите любую клавишу для выхода.");
        Console.ReadLine();
    }

    private static void Board()
    {
        Console.WriteLine(" {0} | {1} | {2} ", board[0], board[1], board[2]);
        Console.WriteLine("---|---|---");
        Console.WriteLine(" {0} | {1} | {2} ", board[3], board[4], board[5]);
        Console.WriteLine("---|---|---");
        Console.WriteLine(" {0} | {1} | {2} ", board[6], board[7], board[8]);
    }

    private static int CheckWin()
    {
        // Проверка строк
        for (int i = 0; i < 3; i++)
        {
            if (board[i * 3] == board[i * 3 + 1] && board[i * 3] == board[i * 3 + 2])
                return (board[i * 3] == 'X') ? 1 : 2;
        }

        // Проверка столбцов
        for (int i = 0; i < 3; i++)
        {
            if (board[i] == board[i + 3] && board[i] == board[i + 6])
                return (board[i] == 'X') ? 1 : 2;
        }

        // Проверка диагоналей
        if (board[0] == board[4] && board[0] == board[8])
            return (board[0] == 'X') ? 1 : 2;
        if (board[2] == board[4] && board[2] == board[6])
            return (board[2] == 'X') ? 1 : 2;

        return 0;
    }
}


