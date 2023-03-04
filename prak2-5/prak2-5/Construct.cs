using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak2_5
{
    internal class Construct
    {
        public int Const1 { get; set; }
        public int Const2 { get; set; }

        public int con1
        {
            get
            { return this.Const1; }
            set
            { this.Const1 = value; }
        }

        public int con2
        {
            get
            { return this.Const2; }
            set
            { this.Const2 = value; }
        }
        public Construct()
        {
            int a = con1;
            int b = con2;
        

            
        ~Construct()
        {
            Console.WriteLine($"данные {a} и {b} были удалены.");
        }
        }
    }
}
