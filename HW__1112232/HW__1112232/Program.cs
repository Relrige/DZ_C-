using System;
using System.IO;

namespace HW__1112232
{
    class Program
    {
        static void Main(string[] args)
        {
            string test;
            string fname = "../../../test.txt";
            using (BinaryWriter bw = new BinaryWriter(new FileStream(fname, FileMode.Create)))
            {
                string str = "Hel3lo4! Прив9іт!1 Wo15215512lrd142423 ";
                bw.Write(str);


            }
            using (BinaryReader br = new BinaryReader(new FileStream(fname, FileMode.Open)))
            {
                string str = br.ReadString();

   
                foreach (char c in str)
                {
                    if (Char.IsDigit(c) == true)
                        str = str.Replace(c.ToString(), "");
                }
                Console.WriteLine($"String = '{str}'");
                test = str;
            }
            using (BinaryWriter bw = new BinaryWriter(new FileStream(fname, FileMode.Create)))
            {
                
                bw.Write(test);


            }



        }
        
    }
}
