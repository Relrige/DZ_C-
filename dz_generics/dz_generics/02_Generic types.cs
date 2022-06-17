using System;

namespace _02_Generic_types
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> st = new MyStack<int>(5);

            Random rnd = new Random();
            for (int i = 0; i < 11; i++)
            {
                int number = rnd.Next(100);
                Console.WriteLine($"\t\tPush data {number}");
                st.Push(number);
            }
            Console.WriteLine($"\n\nTop = {st.Peek()}");
            int c = 0;
            Console.WriteLine($"\n\nTryPeek = {st.TryPop(out c)}, Top = {c}");
            Console.WriteLine($"\n\nTryPeek = {st.TryPeek(out c)}, Top = {c}");

            //st.Pop();
            //Console.WriteLine($"\n\nTop = {st.Peek()}");

            //while (!st.Empty())
            //{
            //    Console.WriteLine($"\n\nTop = {st.Peek()}");
            //    st.Pop();
            //}

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }





        }   
    }
}

