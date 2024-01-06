using System;
internal class Program5
    {
       static void Main(string[] args) 
    {
        int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[i, j];
            }
            Console.WriteLine("The sum of row {0} is {1}", i + 1, sum);
        }

    }

}

