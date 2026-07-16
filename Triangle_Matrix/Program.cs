using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Matrix
{
    using System;

    using System;

    class Program
    {
        static void Main()
        {
            int width = 9;
            int height = 5;

            char[,] matrix = new char[height, width];

            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = ' ';
                }
            }

            
            int center = width / 2;

            for (int i = 0; i < height; i++)
            {
                for (int j = center - i; j <= center + i; j++)
                {
                    matrix[i, j] = '*';
                }
            }

            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}