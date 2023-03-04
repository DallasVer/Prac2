using System;

namespace prak2_5
{
    internal class Program
    {
        static void Test()
        {
            Construct del = new Construct();
        }
        static void Main(string[] args)
        {
            Construct Val = new Construct();

            Console.WriteLine("Напишите два новых свойства.");
            Console.WriteLine("Введите первое значение");
            Val.con1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе значение");
            Val.con2 = int.Parse(Console.ReadLine());

            Console.WriteLine("1: Удалить оба пункта.");
            int res = Convert.ToInt32(Console.ReadLine());
                Test();
                GC.Collect();
                Console.ReadKey();
            }
        }
    }
