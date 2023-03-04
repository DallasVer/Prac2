using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace prak2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student nem = new Student();
            
            for(int i = 0;i < 10; i++) { 
            Console.WriteLine("Выберите пункт \n 1: Просмотреть существующие данные. \n 2: Изменить данные. \n 3: Закрыть меню");
                int res = Convert.ToInt32(Console.ReadLine());
                switch(res)
                 {
                 case 1: nem.Print(); break;
                 case 2: 
                Console.WriteLine("Меню выбора: \n 1-изменить ФИО,\n 2-изменить дату рождения,\n 3-изменить группу, \n 4-выход из меню \n");
                int izmen = Convert.ToInt32(Console.ReadLine());
                    switch (izmen) {
                    case 1:
                        {
                            Console.WriteLine("Введите ФИО");
                                    nem.FIO = Console.ReadLine();
                            Console.WriteLine($"новое ФИО: {nem.FIO}");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Введите дату");
                            nem.Data = Console.ReadLine();
                            Console.WriteLine($"новая дата: {nem.Data}");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Введите группу");
                            nem.Grup = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"новая группа: {nem.Grup}");
                            break;
                        }
                }; break;
                 case 3: return; 
                 default: Console.WriteLine("Данного меню не существует"); break;
                 }

                
                
                
            } 
        }
    }
}