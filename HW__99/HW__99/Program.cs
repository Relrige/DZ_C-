using System;
using System.Linq;

namespace HW__99
{
    delegate void DrawDelegate(ConsoleColor c, int height);
    class Drawers
    {

        public static void DrawTriangle(ConsoleColor color, int height)
        {
            var tmp = Console.ForegroundColor;
            Console.ForegroundColor = color;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = tmp;
        }

        public static void DrawSquare(ConsoleColor color, int height)
        {
            var tmp = Console.ForegroundColor;
            Console.ForegroundColor = color;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = tmp;
        }
    }
    class Program
    {
        delegate bool MyPredicate(int number);
        static uint MyCount(int[] arr, MyPredicate predic)
        {
            uint count = 0;
            foreach (var item in arr)
            {
                if (predic(item))
                {
                    ++count;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            
            DrawDelegate dd = new DrawDelegate(Drawers.DrawTriangle);
            dd.Invoke(ConsoleColor.Red, 10);
            dd = Drawers.DrawSquare;
            dd.Invoke(ConsoleColor.Green, 10);
            Console.WriteLine("                 ");
            //Drawers.DrawTriangle(ConsoleColor.Red, 20);
            
            Console.WriteLine("                 ");
            dd += Drawers.DrawTriangle;
            dd.Invoke(ConsoleColor.Blue, 8);
            Console.WriteLine("                 ");

        }
    }
}