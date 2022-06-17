using System;
using System.IO;

namespace HW_1001
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "numbers.dat";
            using (FileStream fs = new FileStream(fname, FileMode.Create))
            {
                fs.WriteByte(65);
                byte[] arr = new byte[] { 66, 67, 68, 69, 90 };
                fs.Write(arr, 0, arr.Length);
            }
            using (FileStream fs = new FileStream(fname, FileMode.Open))
            {
                byte[] result = new byte[fs.Length];
                fs.Read(result, 0, result.Length);
                Console.WriteLine($"{ String.Join(" ", result)}");

            }

        }
    }
}