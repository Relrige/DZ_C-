using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkInheritanceCSharp
{
    public class Rectangle : Shape
    {
        private double higth;
        private double length;
        public double Higth
        {
            get => higth;
            set => higth = value;
        }
        public double Length
        {
            get => length;
            set => length = value;
        }
        public override double Area
        {
            get => higth * length;
        }

        public override double Lenght
        {
            get => 2*(higth + length);
        }
        public Rectangle(double len,double higth)
        {
            Higth = higth;
            Length= len;
        }
        public override void Draw()
        {
            for (int i = 0; i < length; i++)
            {
                Console.SetCursorPosition(basePoint.X, basePoint.Y++);
                for (int j = 0; j < higth; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        public override void Print()
        {
            Console.WriteLine($"Name : {nameof(Rectangle)}, Area : {Area}, Perimetr : {Lenght}");
        }
    }
}
