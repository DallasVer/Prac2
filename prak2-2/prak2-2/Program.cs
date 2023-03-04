using System.Xml.Linq;

namespace prak2_2
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Train> bas = new List<Train>();
            string raz = null;

            bas.Add(new Train("Котёночкино",456,"13:20"));
            bas.Add(new Train("Метронов",100,"01:50"));
            bas.Add(new Train("City17", 036, "07:10"));
            bas.Add(new Train("Оружейный", 226, "01:50"));

            while (true) {
                Console.WriteLine("Выберите пункт \n 1: Вывести данные поезда. \n 2: Закрыть меню");
                int res = Convert.ToInt32(Console.ReadLine());
            switch (res)
            {
                case 1:
                    Console.WriteLine("Введите номер поеда, информацию о котором вы хотите узнать.");
                    int name = Convert.ToInt32(Console.ReadLine());
                    foreach (Train Nums in bas)
                    {
                    if(Nums.Number == name) 
                    { 
                     raz = Nums.rezultat();           
                    }
                    }
                    if (raz == null) 
                    { 
                    Console.WriteLine("Такого поезда нет."); 
                    }                    
                    else
                    { 
                    Console.WriteLine(raz); 
                    }
                    raz = null;
                    break;
                case 2: 
                return; 
            }
        }        
     } 
    }
}