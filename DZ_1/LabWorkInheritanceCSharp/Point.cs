using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkInheritanceCSharp
{
    class Point :Shape
    {
        public override double Area
        {
            get => 0;
        }
        public override double Lenght
        {
            get => 0;
        }

        public override void Draw()
        {
            Console.SetCursorPosition(basePoint.X, basePoint.Y);
            Console.WriteLine('*');
        }

        public override void Print()
        {
            Console.WriteLine();
        }
    }
}
