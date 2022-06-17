using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkInheritanceCSharp
{
    class Canvas
    {
        List<Shape> shapes = new List<Shape>();
        private double length;
        public double Length
        {
            get => length;
            set => length = value;
        }

        public static void Add(Shape s)
        {

            //shapes.Add(new Shape() { Length = 50,Higth =70 });
            //shapes.Add(new Rectangle() { Length = 1000});
        }
        public void Draw()
        {
            Console.WriteLine();
        }
        public void Clear()
        {
            Console.Clear();
        }
        
    }
}
