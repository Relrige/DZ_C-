using System;

namespace HW_OVERLOAD
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v = new Vector(1, 2);
            Vector v2 = new Vector(0, 0);
            Vector v3 = new Vector(3, 2);
            Console.WriteLine($"Vector :{ v}");
            if (v)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            if (v2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            
            Console.WriteLine($"--{ v--}");
            Console.WriteLine($"after --:{ v}");
            Console.WriteLine($"-:{-v}");
            Console.WriteLine($"++:{ v++}");
            Console.WriteLine($"after ++ :{ v}");
            Console.WriteLine($"GetHashCode v :{v.GetHashCode()}");
            Console.WriteLine($"GetHashCode v2 :{v2.GetHashCode()}");

            Console.WriteLine();
            Console.WriteLine($"before v2+= :{v2}");
            v2 += v;
            Console.WriteLine($"after v2+= :{ v2}");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine($"before v2+= :{v2}");
            v2 *= v;
            Console.WriteLine($"after v2+= :{ v2}");
            Console.WriteLine();

            Console.WriteLine($"v3 +v2 = {v3+v2}"); 
            Console.WriteLine($"v3*v2 = {v3*v2}"); 
            Console.WriteLine($"v3-v2 = {v3-v2}"); 
            Console.WriteLine($"v3!=v2 = {v3!=v2}"); 
               
        }
    }
    }
