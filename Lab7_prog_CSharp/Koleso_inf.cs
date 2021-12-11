using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace info_Koleso_inf
{
    abstract class Koleso_inf
    {
        public Koleso_inf()
        {
        }
        public abstract double obem();
        public abstract int perimetr();

        protected int diametr;
        protected int visota;
        protected int shirina;
        protected string tip_diska;

    }
}
