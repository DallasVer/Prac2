using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak2_2
{
    class Train
    {
        public string Punkt;
        public int num;
        public string Time;

        public Train(string Punkt, int num, string Time)
        {
            this.Punkt = Punkt;
            this.num = num;
            this.Time = Time;
        }

        public int Number { get { return num;} }

        public string rezultat()
        {
            return("Пункт назначения:" +Punkt+ " \n Номер поезда:" + num + "\n Время отправления:" + Time);
        }

    }
}

