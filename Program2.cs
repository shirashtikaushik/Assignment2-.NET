using System;

    internal class Program2
    {
        static void Main(string[]args)
        {
            int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum += matrix[i, j];
                }
            }
            Console.WriteLine("The sum of the matrix is {0}", sum);

        }
    }

