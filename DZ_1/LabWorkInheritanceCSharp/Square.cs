using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkInheritanceCSharp
{
    public class Square : Shape
    {
        private double side;
        public double Side
        {
            get => side;
            set => side = value;
        }
        public override double Area
        {
            get => Side * Side;
        }
        public override double Lenght
        {
            get => Side *4;
        }
        public Square(double s)
        {
            Side = s;
        }
        public override void Draw()
        {
            for (int i = 0; i < side; i++)
            {
                Console.SetCursorPosition(basePoint.X, basePoint.Y++);
                for (int j = 0; j < side; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public override void Print()
        {
            Console.WriteLine($"Name : {nameof(Square)}, Area : {Area}, Perimetr : {Lenght}");
        }
    }
}
