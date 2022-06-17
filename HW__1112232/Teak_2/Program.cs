using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Teak_2
{
    class Student
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Specialization { get; set; }
        public int[] Marks{ get; set; }

        int[] marks;
        public Student(string name,string sn, string specialization)
        {
            Name = name; 
            SurName = sn; 
            Specialization = specialization; 
            this.marks = new int[0]; 
        }
        public Student(string name, string sn, string specialization,int[] m)
        {
            Name = name;
            SurName = sn;
            Specialization = specialization;
            this.marks = m;
        }
        public Student(string name = "Noname",string sn = "NoSurName")
        : this(name,sn, "Unknown") 
        { }
        public double AvgMark => marks.Length != 0 ? marks.Average() : 0;
        public void Print()
        {
            Console.WriteLine($"Name : {Name,-10} SurName :{SurName,-10 } Spec : {Specialization,-10}");
        }
        public override string ToString() 
        {
            return $"Name : {Name,-10} SurName :{SurName,-10 } Spec : {Specialization,-10} MARKS: {String.Join(", ", marks)}";
        }
    }
    class FileWorker
    {
        public static void SaveStudents(Student[] student, string filename)
        {
            using (BinaryWriter bw = new BinaryWriter(new FileStream(filename, FileMode.Create)))
            {
                bw.Write(student.Length);

                foreach (Student s in student)
                {
                    bw.Write(s.Name);
                    bw.Write(s.SurName);
                    bw.Write(s.Specialization);

                    //bw.Write(s.Marks.Length);
                    //foreach (var item in s.Marks)
                    //{
                    //    bw.Write(item);
                    //}
                }
            }
        }

        public static Student[] LoadStudents(string filename)
        {
            using (BinaryReader br = new BinaryReader(new FileStream(filename, FileMode.Open)))
            {
                Student[] st=new Student[br.ReadInt32()];


                Console.WriteLine("_________Students__________");
                for (int i = 0; i < st.Length; i++)
                {
                    string name = br.ReadString();
                    string Sname = br.ReadString();
                    string Specil = br.ReadString();
                    //int[] arr = new int[br.ReadInt32()]; 
                    //for (int j = 0; j < arr.Length; j++)
                    //{
                    //    arr[j] = br.ReadInt32();
                    //}
                    st[i]=new Student(name, Sname,Specil/*,arr*/);
                    
                    Console.WriteLine(st[i]);
                }
                return st;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string Fname = "../../../test2.txt";
            int[] a = { 1, 9, 10, 12, 9 };
            Student s1 = new Student("Vasya", "Vasiliiy", "Maths");
            Student s2 = new Student("Misha", "MAshovsky", "Maths");
            Student s3 = new Student("Anna", "Kluvchuk", "Physics");
            Student s4 = new Student("Dima", "Litvinchuc", "Physics");
            Student s5 = new Student("Masha", "Pronevich", "English");
            Student[] student = new Student[5];
            student[0] = s1;
            student[1] = s2;
            student[2] = s3;
            student[3] = s4;
            student[4] = s5;
            FileWorker.SaveStudents(student, Fname);
            FileWorker.LoadStudents(Fname);
        }
    }
}
