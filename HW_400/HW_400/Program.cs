//using System;

//namespace HW_400
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            HotHouse hotHouse = new HotHouse(15);
//            Cooler cooler = new Cooler();
//            Heather heather = new Heather();

//            hotHouse.TooHot += heather.Warm;
//            hotHouse.TooCold += cooler.Cold;
//            Console.WriteLine($"Temp = {hotHouse.CurrentTemperature}");
//            //Console.WriteLine(hotHouse);
//            //hotHouse.CurrentTemperature += 2;
//            //for (int i = 0; i < 5; i++)
//            //{
//                //int tmp = new Random().Next(-2, 2);
//                //Console.WriteLine(tmp);
//                //hotHouse.CurrentTemperature=hotHouse.CurrentTemperature + tmp;
//                //Console.ReadKey();
//            //}



//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_400
{
    class Program
    {
        static void Main(string[] args)
        {
            Cooler cooler = new Cooler();
            Heather heather = new Heather();
            HotHouse hotHouse = new HotHouse
            { CurrentTemperature = 15 };
            Console.WriteLine($"Temperature : {hotHouse.CurrentTemperature}");
            hotHouse.TooHot += heather.Warm;
            hotHouse.TooCold += cooler.Cold;

            for (int i = 0; i < 5; i++)
            {
                int tmp = new Random().Next(-2, 2);
                hotHouse.CurrentTemperature += tmp;
                Console.WriteLine($"Temperature : {hotHouse.CurrentTemperature}");
                Console.ReadKey();
            }



        }
    }
}