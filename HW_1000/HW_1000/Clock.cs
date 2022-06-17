using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1000
{
    class ClockEventArgs
    {
        public ClockEventArgs(byte hs, byte min)
        {
            this.Hours = hs;
            this.Minutes = min;
        }
        public byte Hours { get; set; }
        public byte Minutes { get; protected set; }
    }
    class Clock
    {
        public Clock(byte hs, byte min)
        {
            Hours = hs;
            Minutes = min;
        }
        public event EventHandler<ClockEventArgs> Alarm;
        byte hoursA;
        byte minutesA;
        byte hours;
        byte minutes;
        public byte Hours
        {
            get => hours;
            set
            {
                if (value > 23)
                {
                    hours = 0;
                }
                else
                {
                    hours = value;
                }
            }
        }
        public byte Minutes
        {
            get => minutes;
            set { if (value > 59) { Hours++; minutes = 0; } else { minutes = value; } }
        }
        public void Tick()
        {
            Minutes++;
            if (minutesA == Minutes && hoursA == Hours)
                Alarm?.Invoke(this, new ClockEventArgs(hoursA, minutesA));
        }
        public void SetAlarm(byte hours, byte minutes)
        {
            hoursA = hours;
            minutesA = minutes;
            Alarm += Alarm_GoOn;
        }
        public void Alarm_GoOn(object sender, ClockEventArgs e)
        {
            Console.WriteLine($"Alarm work {e.Hours} : {e.Minutes}");
        }
        public override string ToString()
        {
            return $"Hour - {hours}\n" +
                $"Minute - {minutes}";
        }
    }
}
