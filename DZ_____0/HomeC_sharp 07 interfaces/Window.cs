using System;
using System.Collections.Generic;
using System.Text;

namespace dz_int
{
    enum TypeWindow { Square, Regtangle, Shape }
    class Window : IPart
    {
        private TypeWindow type;
        public Window(TypeWindow window)
        {
            this.type = window;
        }
        public void Work(House house)
        {
            house.window.Add(new Window(new TypeWindow()));
        }
    }
}