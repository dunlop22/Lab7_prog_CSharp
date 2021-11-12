using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using info_motor;
using info_obchee;
using info_korobka;
using info_koleso;

namespace info_avto
{
    class Avto
    {

        Motor Motorishe = new Motor();
        Obchee Obchie = new Obchee();
        Korobka Korobas = new Korobka();
        Koleso Kolesiki = new Koleso();

        //создание автомобиля на основании создданных агрегатов
        public void new_avto(Motor Motorishe1, Obchee Obchie1, Korobka Korobas1, Koleso Kolesiki1)
        {
            this.Motorishe = Motorishe1;
            this.Korobas = Korobas1;
            this.Kolesiki = Kolesiki1;
            this.Obchie = Obchie1;
        }

        //просмотр информации об автомобиле
        public void prosmotr_avto()
        {
            this.Motorishe.prosmotr_motor();
            Console.WriteLine("\n");
            this.Korobas.prosmotr_korobka();
            Console.WriteLine("\n");
            this.Kolesiki.prosmotr_koleso();
            Console.WriteLine("\n");
            this.Obchie.prosmotr_obchee();
            Console.WriteLine("\n");
        }
        
    }
}
