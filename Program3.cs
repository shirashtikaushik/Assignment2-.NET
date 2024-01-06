using System;

    internal class Program3
    {
      static void Main(string[] args) 
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5 };
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine("The maximum element of the array is {0}", max);

    }
}

