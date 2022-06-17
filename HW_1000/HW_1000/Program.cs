using System;

namespace HW_1000
{
    class Program
    {

        static void Main(string[] args)
        {
            Clock cl = new Clock(1,10);
            cl.SetAlarm(1, 50);
            for (int i = 0; i < 60; i++)
            {
                cl.Tick();
            }
            


        }
    }
}