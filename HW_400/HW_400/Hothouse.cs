//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace HW_400
//{
//    delegate void HotHouseDeleg(HotHouse house);
//    class HotHouse
//    {
//        public readonly int MaxTemperature = 250;
//        public readonly int MinTemperature = -100;
//        public event HotHouseDeleg TooHot;
//        public event HotHouseDeleg TooCold;
//        public int CurrentTemperature
//        {
//            get => CurrentTemperature;
//            set
//            {
//                if (value > MaxTemperature)
//                {
//                    Console.WriteLine("Current temperature more max-temperature!");
//                    TooHot?.Invoke(this);
//                }
//                else if (value < MinTemperature)
//                {
//                    Console.WriteLine("Current temperature smoller min-temperature");
//                    TooCold?.Invoke(this);
//                }
//                else
//                {
//                    Console.WriteLine("Well!");
//                }
//                //CurrentTemperature = value;
//            }

//        }

//        public HotHouse(int CurrentTemperature)
//        {
//            this.CurrentTemperature = CurrentTemperature;
//            Console.WriteLine("HotHouse was created");
//        }
//    }
//    class Heather
//    {
//        public Heather()
//        {
//            Console.WriteLine("Heater was created");
//        }
//        public void Warm(HotHouse h)
//        {
//            if (h.CurrentTemperature != h.MaxTemperature && h.CurrentTemperature != h.MinTemperature)
//            {
//                h.CurrentTemperature += 5;
//                Console.WriteLine($"Heather added 5 degrees !");
//            }
//            else
//            {
//                throw new Exception("Error with Max temperature!");
//            }

//        }
//    }
//    class Cooler
//    {
//        public Cooler()
//        {
//            Console.WriteLine("Cooler was created");
//        }
//        public void Cold(HotHouse hotHouse)
//        {
//            if (hotHouse.CurrentTemperature != hotHouse.MaxTemperature && hotHouse.CurrentTemperature != hotHouse.MinTemperature)
//            {
//                hotHouse.CurrentTemperature -= 5;
//                Console.WriteLine($"Cooler minus 5 degrees !");
//            }
//            else
//            {
//                throw new Exception("Error with Min temperature!");
//            }
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
    delegate void HotHouseDeleg(HotHouse house);
    class HotHouse
    {
        private int temperature;
        public readonly int MinTemperature = 10;
        public readonly int MaxTemperature = 20;
        public event HotHouseDeleg TooHot;
        public event HotHouseDeleg TooCold;
        
        public int CurrentTemperature
        {
            get => temperature;
            set
            {
                temperature = value;
                if (value > MaxTemperature)
                {
                    Console.WriteLine("Current temperature more max-temperature!");
                    TooHot?.Invoke(this);
                }
                else if (value < MinTemperature)
                {
                    Console.WriteLine("Current temperature smoller min-temperature");
                    TooCold?.Invoke(this);
                }
                else
                {
                    Console.WriteLine("Well!");
                }
            }
        }

        public HotHouse(int temp=10)
        {
            CurrentTemperature = temp;
        }

    }
    class Heather
    {
        public void Warm(HotHouse hotHouse)
        {
            if (hotHouse.CurrentTemperature != hotHouse.MaxTemperature && hotHouse.CurrentTemperature != hotHouse.MinTemperature)
            {
                hotHouse.CurrentTemperature += 5;
                Console.WriteLine($"Heather added 5 degrees !");
            }
            else
            {
                throw new Exception("Error with Min Max temperature!");
            }

        }
    }
    class Cooler
    {
        public void Cold(HotHouse hotHouse)
        {
            if (hotHouse.CurrentTemperature != hotHouse.MaxTemperature && hotHouse.CurrentTemperature != hotHouse.MinTemperature)
            {
                hotHouse.CurrentTemperature -= 5;
                Console.WriteLine($"Heather minus 5 degrees !");
            }
            else
            {
                throw new Exception("Error with Min Max temperature!");
            }
        }
    }

}