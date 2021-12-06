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
    }
}
