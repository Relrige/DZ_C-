using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorkInheritanceCSharp
{
    static class MyExtention
    {
        public static int CountSum(this int[][] m)
        {
            int count = 0;
            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j <m[i].Length; j++)
                {
                    count += m[i][j];
                }
            }
            return count;
        }
    }
    public class Program
    {

        public static void Print(ref List<Shape> shapes)
        {
            foreach (var item in shapes)
            {
                item.Print();
            }
        }

        public static void Sort(ref List<Shape> shapes)
        {
            shapes = shapes.OrderByDescending(x => x.Area).ToList();
            shapes.Reverse();
        }
        public static List<Shape> FIndAll(ref List<Shape> shapes)
        {
            List<Shape> shapes2 = new List<Shape>();
            for (int i = 0; i < shapes.Count; i++)
            {
                if(shapes[i].GetType() == typeof(Rectangle))
                {
                    shapes2.Add(shapes[i]);
                }
            }
            return shapes2;
        }
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            List<Shape> shapes2 = new List<Shape>();

            shapes.Add(new Rectangle(50, 70));
            shapes.Add(new Square(40));
            shapes.Add(new Square(100));


            Console.WriteLine("Sorting.");
            Sort(ref shapes);

            Console.WriteLine("Printing.");
            Print(ref shapes);

            Console.WriteLine("Find all.");
            shapes2=FIndAll(ref shapes);

            //TASK 2
            int[][] arr=new int[3][];
            arr[0] = new int[] { 1, 3, 5, 7, 9 };
            arr[1] = new int[] { 0, 2, 4, 6 };
            arr[2] = new int[] { 11, 22 };
            Console.WriteLine("TEST");
            Console.WriteLine($" count sum {arr.CountSum()}");
        }
    }
}
