using System;
using System.Collections.Generic;
using System.Text;

namespace dz_int
{
    enum TypeRoof { Stone, Cement, Pitched };
    class Roof : IPart
    {
        public TypeRoof roof;
        public Roof(TypeRoof roof)
        {
            this.roof = roof;
        }
        public void Work(House house)
        {
            house.roof = new Roof(new TypeRoof());
        }
    }
}
