using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak2_1
{
    public class Student
    {
        public string FIO { get; set; }
        public string Data;
        public int Grup;
        public int[] Uspev = { 3, 2, 4, 5, 3 };


        public Student()
        {

            FIO = "Иван Иванович Иванов";
            Data = "01.01.2001";
            Grup = 123;
        }
        public void Print()
        {
            Console.WriteLine($" FIO: {FIO}. \n Дата рождения: {Data}. \n Группа: {Grup}.");
        }
    }
}
