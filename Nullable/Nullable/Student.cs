using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Nullable
{
    class Student
    {
        public Student(string fullName)
        {
            FullName = fullName;
            grades = new List<Grade>();
            ID = ++count;
        }
        string _fullName;
        List<Grade> grades;
        private static int count = 0;
        private int ID;

        public string FullName
        {
            get => _fullName;
            set
            {
                string[] arr = value.Split(" ");
                if (arr.Length == 3)
                {
                    _fullName = value;
                }
                else
                {
                    throw new Exception("bad full name");
                }
            }
        }
        public void AddGrade(Grade grade)
        {
            grades.Add(grade);
            count++;
        }
        public void EditGradeByDate(DateTime date, ushort grade)
        {
            var it = grades.Find((e) => e.Date == date);
            if (it != null)
            {
                it.Mark = grade;
            }
        }
        public void RemoveGrade(int number)
        {
            bool isRemove = EditGradeByNumber(number, null);
            if (isRemove)
                count--;
        }
        public bool EditGradeByNumber(int number, ushort? grade)
        {
            if (number < grades.Count)
            {
                grades[number].Mark = grade;
                return true;
            }

            return false;
        }
        public int AvaregeGrade()
        {
            return (grades.Sum(x => Convert.ToInt32(x.Mark)) / count);
        }
        public int AvaregeGradeNull()
        {
            int ave = 0;
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] == null)
                {
                    ave += 0;
                }
                else
                    ave += Convert.ToInt32(grades[i].Mark);
            }
            ave = ave / grades.Count;
            return ave;
        }

        public override string ToString()
        {
            string data = FullName;
            data +=" ID: "+ID +"\n----------------------------";
            foreach (var item in grades)
            {
                if (item.Mark != null)
                    data += $"\n{item.ToString()}";
            }
            return data;
        }
        public static int CompareByAve(Student p1, Student p2)
        {
            
            // 1 спосіб -  ручний
            if ((p1.AvaregeGrade()) == (p2.AvaregeGrade()))
                return 0;
            if (p1.AvaregeGrade() > p2.AvaregeGrade())
                return 1;
            return -1;
        }
    }
}