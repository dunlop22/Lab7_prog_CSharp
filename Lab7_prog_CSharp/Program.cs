using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using info_koleso;

namespace Lab7_prog_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Koleso Kolesiko = new Koleso();
            int a, b, c;

            Kolesiko.Diametr = -10;
            Kolesiko.Visota = 80;
            Kolesiko.Shirina = 100;
            a = Kolesiko.Diametr; 
            b = Kolesiko.Visota; ;
            c = Kolesiko.Shirina;
            Kolesiko.prosmotr_koleso();
        }
    }
}
