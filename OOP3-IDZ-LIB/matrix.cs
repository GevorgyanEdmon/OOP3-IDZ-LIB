using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3_IDZ_LIB
{
    public class Matrix
    {
        private int m;
        private int n;
        public int[,] numbers;
        public Matrix(int pM, int pN)
        {
            m = pM;
            n = pN;
            numbers = new int[n,m];
            Console.WriteLine("Введите значение матрицы");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Matrix[" + (i+1) + "," + (j+1) + "]: ");
                    numbers[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public static void PrintMatrix(Matrix matrix)
        {
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    Console.Write(matrix.numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void GetMinMax(Matrix matrix)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int minN=0;
            int maxN=0;
            int ind = 0;
            for (int i = 0; i < matrix.m; i++)
            {
                for (int j = 0; j < matrix.n; j++)
                {
                    ind++;
                    if (min > matrix.numbers[i, j])
                    {
                        min = matrix.numbers[i, j];
                        minN=ind;
                    }
                    if (max < matrix.numbers[i, j])
                    {
                        max = matrix.numbers[i, j];
                        maxN=ind;
                    }
                }
            }
            Console.Write($"Min {min} : {minN}, Max {max} : {maxN}");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void PrintResultMatrix(Matrix matrix)
        {
            int[,] trans = new int[matrix.m, matrix.n];
            Console.WriteLine();
            Console.WriteLine("Транспонированная матрица: ");
            Console.WriteLine();
            for (int i = 0; i < matrix.n; i++)
            {
                for (int j = 0; j < matrix.m; j++)
                {
                    trans[i, j] = matrix.numbers[j, i];
                    Console.Write(trans[i, j] + " ");

                    if (j == matrix.m - 1)
                        Console.WriteLine();
                }
            }
        }
    }
}
