using System;
using System.Linq;
using System.Text;

namespace dz_04_02
{
    class Program
    {
        static void RemoveAllCharFromString(ref string str, params char[] charsToRemove)
        {
            foreach (var c in charsToRemove)
            {
                str = str.Replace(c, '\0');
            }
        }
        static void printJugger(char[][] jug)
        {
            foreach (var arr in jug)
            {

                Console.Write($"{arr[0]} [{arr.Length}]");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
        static void CountLetterInString(string str)
        {
            char[] letter = { 'A', 'a', 'B', 'b', 'C', 'c', 'D', 'd', 'E', 'e', 'F', 'f', 'G', 'g', 'H', 'h', 'I', 'i','J','j','K','k','L','l','M','m','N','n','O','o', 'P','p','Q','q','R','r','S','s','T','t','U','u','V','v','W','w','X','x','Y','y','Z','z' };
            char[][] countLetter = new char[0][];
            int index = 0;
            foreach (var item in letter)
            {
                int count = str.Count((e) => e.Equals(item));
                if (count > 0)
                {
                    Array.Resize(ref countLetter, countLetter.Length + 1);
                    Array.Resize(ref countLetter[index], count);
                    countLetter[index][0] = item;
                    ++index;
                }
            }
            printJugger(countLetter);
        }
        static bool check(string str)
        {
            char a = str[0];
            int length = str.Length;
            bool bb =str.All(str => a!='_');
            bool bb1 =str.All( str =>!Char.IsDigit(a) );
            bool bb2 = str.All(str =>length<256);
            if (bb == true && bb1 == true && bb2 == true)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            //string str = "abcdbxad lofdfad";
            //char[] charToDelete = { 'a', 'f','b' };
            //RemoveAllCharFromString(ref str, charToDelete);
            //Console.WriteLine(str);

            //string str2 = "I don’t know whether to delete this or rewrite it";
            //CountLetterInString(str2);

            ////
            string str1 = "Afsfsf";
            bool b =check(str1);
            Console.WriteLine(b);

            string str2 = "2Afsfsf";
            bool bc = check(str2);
            Console.WriteLine(bc);
        }
    }
}
