using System.Xml.Linq;

namespace prak2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter trick = new Counter();
            ConsoleKeyInfo key;

            Console.WriteLine("Инициализация счетчика '~~'\n 1: По умолчанию \n 2: Произвольное значение. \n 3: Выйти.");
                int res = Convert.ToInt32(Console.ReadLine());
                switch (res)
                {
                    case 1:
                        Console.WriteLine("Введите первое значение");
                        trick.Now = int.Parse(Console.ReadLine());
                    break;
                    case 2: 
                        trick.Now = trick.Rand;
                    break;
                    case 3: return;
                }
            while (true)
            {
                Console.WriteLine("Операции со счётчиком: \n 1: Знать текущее состояние \n 2: Работать со счётчиком. \n 3: Выйти.");

                res = Convert.ToInt32(Console.ReadLine());
                switch (res)
                {
                    case 1: Console.WriteLine(trick.Now); break;
                    case 2:
                        Console.WriteLine(" KeyUp ↑︎: Продвинуться вверх \n KeyDown ↓︎: Продвинуться вниз \n Escape: Выйти.");
                        key = Console.ReadKey(true);
                            switch (key.Key)
                            { 
                                case ConsoleKey.DownArrow: trick.Down(); break;
                                case ConsoleKey.UpArrow: trick.Up();  break;
                                case ConsoleKey.Escape: break;
                        }
                        break;
                    case 3: return;
                }
                

            }
        }
    }
}