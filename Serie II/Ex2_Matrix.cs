using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_II
{
    public static class Matrix
    {
        public static int[][] BuildingMatrix(int[] leftVector, int[] rightVector)
        {
            int lengthLeft = leftVector.Length;
            int lengthRight = rightVector.Length;

            int[][] matrix = new int[lengthLeft][];
            for (int i = 0; i < lengthLeft; i++)
            {
                matrix[i] = new int[lengthRight];
                for (int j = 0; j < lengthRight; j++)
                {
                    matrix[i][j] = leftVector[i] * rightVector[j];
                }
            }

            return matrix;
        }

        public static int[][] Addition(int[][] leftMatrix, int[][] rightMatrix)
        {
            int lengthLeft = leftMatrix.Length;
            int lengthRight = rightMatrix[0].Length;

            int[][] matrix = new int[lengthLeft][];
            for (int i = 0; i < lengthLeft; i++)
            {
                matrix[i] = new int[lengthRight];
                for (int j = 0; j < lengthRight; j++)
                {
                    matrix[i][j] = leftMatrix[i][j] + rightMatrix[i][j];
                }
            }

            return matrix;
        }

        public static int[][] Substraction(int[][] leftMatrix, int[][] rightMatrix)
        {
            int lengthLeft = leftMatrix.Length;
            int lengthRight = rightMatrix[0].Length;

            int[][] matrix = new int[lengthLeft][];
            for (int i = 0; i < lengthLeft; i++)
            {
                matrix[i] = new int[lengthRight];
                for (int j = 0; j < lengthRight; j++)
                {
                    matrix[i][j] = leftMatrix[i][j] - rightMatrix[i][j];
                }
            }

            return matrix;
        }

        public static int[][] Multiplication(int[][] leftMatrix, int[][] rightMatrix)
        {
            int n = leftMatrix[0].Length;
            int m = rightMatrix[0].Length;
            int firstValue, secondValue;

            int[][] matrix = new int[m][];
            for (int i = 0; i < m; i++)
            {
                matrix[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    matrix[i][j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        firstValue = leftMatrix[i][k];
                        secondValue = rightMatrix[k][j];
                        matrix[i][j] +=  firstValue * secondValue;
                    }
                }
            }

            return matrix;
        }

        public static void DisplayMatrix(int[][] matrix)
        {
            string s = string.Empty;
            for (int i = 0; i < matrix.Length; ++i)
            {
                for (int j = 0; j < matrix[i].Length; ++j)
                {
                    s += matrix[i][j].ToString().PadLeft(5) + " ";
                }
                s += Environment.NewLine;
            }
            Console.WriteLine(s);
        }
    }
}
