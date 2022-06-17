using System;
using System.Collections.Generic;
using System.Text;

namespace dz_int
{
    class House
    {
        public Basement basement;
        public List<Walls> walls;
        public List<Window> window;
        public Roof roof;
        public Door door;

        public void RenderHouse()
        {
            string str = @"
                *
               * *
              * * *
             * * * *
             *     *
             *     *
             *     *
             *******
            ";
            Console.WriteLine("HOUSE IS DONE");
            Console.WriteLine(str);
        }

    }
}

