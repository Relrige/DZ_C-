using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkInheritanceCSharp
{

    public abstract class Shape
    {
        protected Position basePoint=new Position(5,3);

        public ConsoleColor color;
        public abstract double Area { get; }
        public abstract double Lenght { get; }
        public abstract void Print();
        public abstract void Draw();

    }
}
