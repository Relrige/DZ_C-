using System;
using System.Collections.Generic;
using System.Text;

namespace Nullable
{
    class Grade
    {
        private ushort? grade;
        private DateTime date;
        public Grade(ushort? grade, DateTime date)
        {
            Mark = grade;
            Date = date;
        }
        public ushort? Mark
        {
            get => grade;
            set
            {
                if (value == null)
                {
                    grade = value;
                }
                else if (value > 0 && value < 13)
                {
                    grade = value;

                }
                else
                {
                    throw new Exception("bad grade");
                }

            }
        }
        public DateTime Date
        {
            get => date;
            set
            {
                if (value >= DateTime.Today)
                {
                    date = value;
                }
                else
                {
                    throw new Exception("Bad Date");
                }

            }
        }
        public override string ToString()
        {
            return $"Grade : {Mark,3} | date {Date.ToShortDateString()}";
        }
    }
}