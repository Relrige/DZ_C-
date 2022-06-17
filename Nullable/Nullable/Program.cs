using System;

namespace Nullable
{
    class Program
    {
        static (double numbBiggest, string stringBiggest) Method1(params object[] arr)
        {
            double numbB = 0;
            string stringB = "";
            for (int i = 0; i < arr.Length; i++)
            {
                switch (arr[i])
                {
                    case int:
                        if ((int)arr[i] > (int)numbB)
                        {
                            numbB=(int)arr[i];
                        }
                        break;
                    case double:
                        if ((double)arr[i] > numbB)
                        {
                            numbB=(double)arr[i];
                        }
                        break;
                    case string:
                        if (((string)arr[i]).Length > stringB.Length)
                            stringB = (string)arr[i];
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            }
            return (numbB, stringB);
        }
        static void Main(string[] args)
        {
            Student student = new Student("Kylakevych Stanislav Vitalovych");

            Grade gr = new Grade(9, new DateTime(2023, 10, 10));
            student.AddGrade(gr);
            student.AddGrade(new Grade(10, new DateTime(2022, 6, 1)));
            student.AddGrade(new Grade(12, new DateTime(2022, 5, 4)));
            student.RemoveGrade(0);
            student.EditGradeByNumber(1, 7);
            Console.WriteLine(student);
            Console.WriteLine(student.AvaregeGrade());
            Console.WriteLine(student.AvaregeGradeNull());


            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            object[] arr2 = { 10, 2.3, 4.7, 34, "stra","fokdko ofa", "asd", true };
            var result2 = Method1(arr2);
            //Console.WriteLine(result2);
            Console.WriteLine($"Number of dodatnii :{result2.numbBiggest}, sum of double : {result2.stringBiggest}");


        }
    }
}