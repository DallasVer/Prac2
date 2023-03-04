namespace prak2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person rub = new Person();
            while (true)
            {
                Console.WriteLine("Выберите пункт \n 1: Вывести на экран числа. \n 2: Изменить числа. \n 3: Найти сумму чисел \n 4: Найти наибольшее из чисел. \n 5: Закрыть меню.");
                int res = Convert.ToInt32(Console.ReadLine());
                switch (res) {
                    case 1: 
                        rub.Vivod(); 
                        break;
                    case 2:
                        Console.WriteLine("Введите первое значение");
                        rub.Zna1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе значение");
                        rub.Zna2 = int.Parse(Console.ReadLine()); 
                        break;
                    case 3: 
                        Console.WriteLine($" Сумма чисел {rub.Zna1} и {rub.Zna2} = {rub.Zna1 + rub.Zna2}");
                        break;
                    case 4: rub.more(); break;
                    case 5: return;
            }
            }
        }
    }
}