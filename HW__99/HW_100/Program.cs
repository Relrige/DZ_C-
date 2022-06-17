using System;

namespace HW_100
{
    public delegate bool MyPredicate(int number);
    static class Array_Extension
    {
        public static int Method(this int[] arr, MyPredicate predicate)
        {
            int a = 0;
            foreach (var item in arr)
            {
                if (predicate(item))
                {
                    return a;

                }
                a++;
            }
            return -1;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, -7 };
            Console.WriteLine($"Index :{arr.Method(x => x % 4 == 0)}");
        }
    }
}