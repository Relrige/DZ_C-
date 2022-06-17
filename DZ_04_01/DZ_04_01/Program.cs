using System;

namespace DZ_04_01
{
    class Program
    {
        static int[][] CreateJuggedArr(params int[] cols)
        {
            int[][] m = new int[cols.Length][];

            for (int i = 0; i < m.Length; i++)
            {
                m[i] = new int[cols[i]];
            }

            return m;
        }

        static void FillRand(int[][] matrix, int left, int right)
        {
            Random rand = new Random();

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = rand.Next(left, right + 1);
                }
            }
        }

        static void PrintJugged(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($"{matrix[i][j], 10}\t");
                }
                Console.WriteLine();
            }
        }

        static void Up(ref int[][] matrix, int indexOfRow, int count)
        {
            //if (indexOfRow != 0)
            //{
                //if (indexOfRow - count >-1)
                //{
                    for (int i = indexOfRow; i > indexOfRow - count; i--)
                    {
                        SwapRows(matrix, i, i - 1);
                    }
              //  }
            //}
        }
        static void SwapRows<T>(T[][] m, int row1, int row2)
        {
            if (!IsValidRow(row1) || !IsValidRow(row2))
            {
                return;
            }
            T[] tmp = m[row1]; // свопаємо посилання на рядки 
            m[row1] = m[row2];
            m[row2] = tmp;

            bool IsValidRow(int r) => r >= 0 && r < m.Length;
        }
        static void AddRow(ref int[][] matrix, int index, int[] newRow)
        {
            Array.Resize(ref matrix, matrix.Length + 1);
            matrix[matrix.Length-1] = newRow;
            SwapRows(matrix, matrix.Length - 1, index);
            for (int i = matrix.Length-1; i > index+1; i--)
            {
                SwapRows(matrix, i, i - 1);
            }
        }
        static void Remove(ref int[][] matrix, int index)
        {
            int[][] tmp = new int[matrix.Length - 1][];

            int j = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                else
                {
                    tmp[j] = matrix[i];
                    j++;
                }
            }

            Array.Resize(ref matrix, matrix.Length - 1);
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = tmp[i];
            }
        }

        static void Down(ref int[][] matrix, int indexOfRow, int count)
        {
            if (indexOfRow != matrix.Length)
            {
                if (indexOfRow + count < matrix.Length)
                {
                    for (int i = indexOfRow; i < indexOfRow + count; i++)
                    {
                        SwapRows(matrix, i, i + 1);
                        //SwapRows(matrix, i, i - 1);
                    }
                }
            }
        }
        static void Main()
        {
            int[][] matrix = CreateJuggedArr(2, 3, 6, 5,4);
            FillRand(matrix, 1, 100);

            PrintJugged(matrix);
            Console.WriteLine();
            int[] arr = { 1, 2, 3, 4, 5 };
            AddRow(ref matrix,1,arr);
            //Remove(ref matrix, 1);
            PrintJugged(matrix);
            Console.WriteLine();
            Console.WriteLine();
            Down(ref matrix, 0, 2);
            PrintJugged(matrix);
           
            Console.WriteLine();
            Console.WriteLine();
            Up(ref matrix, 3, 2);
            PrintJugged(matrix);
        }
    }
}
