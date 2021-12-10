using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using info_koleso;

namespace info_koleso_zapaska
{
    class Koleso_Zapaska : Koleso
    {
        public string vid;
        public Koleso_Zapaska()
        {

        }
        public void set (int diametr, int visota, int shirina, string tip_diska, string vid)
        {
            this.diametr = diametr;
            this.shirina = shirina;
            this.visota = visota;
            this.tip_diska = tip_diska;
            this.vid = vid;
        }

        public void print()
        {
            Console.WriteLine("Тип запасного колеса: " + this.vid + "\n\n");
        }
        public void vid_set(string vid1)
        {
            this.vid = vid1;
        }
        public void set_new()
        {
            this.diametr = base.diametr;
            this.shirina = base.shirina;
            this.visota = base.visota;
            this.tip_diska = base.tip_diska;

        }

        public Koleso_Zapaska(int diametr, int visota, int shirina, string tip_diska, string vid) : base(diametr, visota, shirina, tip_diska)
        {
            this.vid = vid;
        }
    }
}
