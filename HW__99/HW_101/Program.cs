using System;

namespace HW_101
{
    public delegate int MyPredicate(int number);
    static class Array_Extension
    {

        public static int[] Method1(this int[] arr, MyPredicate predicate)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(predicate(item));
            }
            return arr;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, -7 };
            int[] arr1 = { 4, 4, 4, 4, 4, 4, 4 };

            MyPredicate predicate = new MyPredicate(x => x * 4);

            Console.WriteLine($"Index * 4");
            Console.WriteLine((arr = arr.Method1(predicate)));


            Console.WriteLine($"Index ++");
            arr = arr.Method1(x => ++x);




        }
    }
}

