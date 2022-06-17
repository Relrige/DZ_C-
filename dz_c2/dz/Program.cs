using System;
using System.Linq;

namespace dz
{
    class Program
    {
        static void PrintArray<T>(T[] arr)
        {
            foreach (var elem in arr)
            {
                Console.Write(elem + "\t");
            }
            Console.WriteLine();
        }

        static void ChangePlaceOn(int[] arr)
        {
            int[] less = Array.FindAll(arr, e => e < 0);
            int[] top = Array.FindAll(arr, e => e > 0);

            less.CopyTo(arr, 0);
            top.CopyTo(arr, less.Length);
        }

        static int FillRandomAndCount(int first, int second, int count, ref int[] array)
        {
            Random rnd = new Random();
            int counter = 0;
            Array.Resize(ref array, count);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(first, second);
                counter++;
            }
            return counter;
        }

        //static int SumElements(int[] array)
        //{
        //    int first = Array.IndexOf(array, array.Max());
        //    int second = Array.IndexOf(array, array.Min());

        //    int sum = 0;
        //    for (int i = second; i <= first; i++)
        //    {
        //        sum += array[i];
        //    }
        //    return sum;
        //}

        static int FindSumOfOneNumberElement(int[] array)
        {
            int counter = 0;
            foreach (var item in array)
            {
                if (item % 2 == 0 && item > 0 && item < 10)
                {
                    counter += item;
                }
            }

            return counter;
        }

        static void SortByPrice(string[] strArray, int[] array)
        {
            Array.Sort(array,strArray);
            Array.Reverse(strArray);
            Array.Reverse(array);
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 21, 2, 19, 7, 110, 10 };
            PrintArray(array);
            Console.WriteLine();
            int index = Array.FindIndex(array, IsOdd);
            Console.WriteLine();
            if (index != -1)
            {
                Console.WriteLine($"\t\tValue %2 == 0  is {array[index]} first  occur) found in index {index}");
            }
            int[] arr1 = new int[array.Length-index-1];
            Array.Copy(array, ++index, arr1, 0, array.Length - index);
            PrintArray(arr1);
            Console.WriteLine($"Sum = {arr1.Sum()} ");
            Console.WriteLine($"Avg = {arr1.Average()} ");
            Console.WriteLine($"Max = {arr1.Max()} ");


            int[] array1 = { 1, 12, -6,14, -7, 10, -100,84 };
            ChangePlaceOn(array1);
            PrintArray(array1);

            Console.WriteLine();
            int[] array3 = { 20, 30, 10, 28, 14,60,100  };
            string[] strArray = { "Bread", "Milk", "Water", "Chips", "yogurt", "Cheese", "meat" };
            SortByPrice(strArray, array3);
            PrintArray(array3);
            PrintArray(strArray);
            
        }
        private static bool IsOdd(int number)
        {
            return number%2==0;
        }
    }
}