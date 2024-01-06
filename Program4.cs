using System;

 internal class Program4
    {
       static void Main(string[] args)
    {
        int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[] colSum = new int[arr.GetLength(1)];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                colSum[j] += arr[i, j];
            }
        }
        Console.WriteLine("The column-wise sum of the 2D array is:");
        for (int i = 0; i < colSum.Length; i++)
        {
            Console.WriteLine("Column {0}: {1}", i + 1, colSum[i]);
        }

    }

}

