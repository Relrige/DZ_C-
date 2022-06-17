using System;
using System.Collections.Generic;
using System.Text;

namespace dz_int
{
    class Walls : IPart
    {
        public ushort HeightWall { get; set; }
        public ushort WeightWall { get; set; }
        public Walls(ushort height = 0, ushort weight = 0)
        {
            this.HeightWall = height;
            this.WeightWall = weight;
        }
        public void Work(House house)
        {
            house.walls.Add(new Walls());
        }
    }
}
