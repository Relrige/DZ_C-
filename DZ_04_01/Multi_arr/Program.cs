using System;

namespace Multi_arr
{
    class Program
    {
        static int[,,] CreateJuggedArr(int a,int b,int c)
        {
            int[,,] m = new int[a,b,c];

            return m;
        }
        static void FillRand(int[,,] matrix, int left, int right)
        {
            Random rand = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    for (int j = 0; j < matrix.GetLength(2); j++)
                    {
                        matrix[i,k,j] = rand.Next(left, right + 1);
                    }
                }
            }
        }
        private static void PrintMatrix(int[,,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    for (int j = 0; j < matrix.GetLength(2); j++)
                    {
                        Console.Write(matrix[i,k, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        static void SumOfAll(int[,,] matrix)
        {
            int sum1=0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    for (int j = 0; j < matrix.GetLength(2); j++)
                    {
                        sum1 += matrix[i, k, j];
                    }
                }
            }

            Console.WriteLine($"Sum of all : {sum1}");
        }
        static void Sum(int[,,] matrix)
        {
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    for (int j = 0; j < matrix.GetLength(2); j++)
                    {
                        sum2 += matrix[0, k, j];
                        sum1 += matrix[i, k, j];
                    }
                }
                    Console.WriteLine($"Sum of {i} arr {sum2}");
            }

            Console.WriteLine($"Sum of all : {sum1}");
        }
        static void Main(string[] args)
        {
            int[,,] arr=CreateJuggedArr(2,2,2);
            FillRand(arr, 1, 100);
            PrintMatrix(arr);
            //SumOfAll(arr);
            Sum(arr);

        }
    }
}
