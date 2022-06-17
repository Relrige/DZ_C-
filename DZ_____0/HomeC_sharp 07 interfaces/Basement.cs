using System;
using System.Collections.Generic;
using System.Text;

namespace dz_int
{
    class Basement : IPart
    {
        public ushort Height { get; set; }
        public ushort Weight { get; set; }
        public Basement(ushort Height = 0, ushort Weight = 0)
        {
            this.Height = Height;
            this.Weight = Weight;
        }
        public void Work(House house)
        {
            house.basement = new Basement();
        }
    }
}
