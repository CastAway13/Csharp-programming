using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Asignment1_1
{
    class Program
    {
        static readonly Random ranVar = new Random();
        static int randomNumber(int min, int max)
        {
            return ranVar.Next(min, max);
        }
        static void Generate(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = randomNumber(1,100);
        }

        static void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write("{0,5}", matrix[i, j]);

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static int[,] AddMatrix(int[,] matrix1, int[,] matrix2)
        {
            int[,]sum = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

            for (int i = 0; i < matrix1.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix1.GetLength(1); ++j)
                {
                    sum[i,j] = matrix1[i,j] + matrix2[i,j];
                }
            }
            return sum;
        }

        static int[,] SubtractMatrix(int[,] matrix1, int[,] matrix2)
        {
            int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

            for (int i = 0; i < matrix1.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix1.GetLength(1); ++j)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return result;
        }

        static int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
        {
            int[,] mult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    mult[i, j] = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        mult[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return mult;
        }

        static void Main(string[] args)
        {

            int rows = randomNumber(1, 5);
            int cols = randomNumber(1, 5);

            int[,] matrix1 = new int[rows, cols];
            int[,] matrix2 = new int[rows, cols];

            Generate(matrix1);
            Generate(matrix2);

            Console.WriteLine("Matrix 1:");
            Print(matrix1);
            Console.WriteLine("Matrix 2:");
            Print(matrix2);

            Console.WriteLine("Add matrix:");
            Print(AddMatrix(matrix1,matrix2));
            Console.WriteLine("Subtract matrix:");
            Print(SubtractMatrix(matrix1, matrix2));

            if (rows == cols)
            {
                Console.WriteLine("Multiply matrix:");
                Print(MultiplyMatrix(matrix1, matrix2));
            }
            else
            {
                int rowMulti = 0, colMulti = 0;
                while (rowMulti != cols)
                {
                    rowMulti = randomNumber(1, 5);
                    colMulti = randomNumber(1, 5);
                }
                int[,] matrix3 = new int[rowMulti, colMulti];
                Generate(matrix3);
                Console.WriteLine("Matrix use for multiplication:");
                Print(matrix3);
                Console.WriteLine("Multiply matrix:");
                Print(MultiplyMatrix(matrix1, matrix3));
            }

            Console.ReadLine();


        }
    }
}
