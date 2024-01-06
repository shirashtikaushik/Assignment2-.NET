namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 10, 15, 20, 25 };

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            double average = (double)sum / numbers.Length;


            Console.WriteLine($"Sum of elements: {sum}");
            Console.WriteLine($"Average of elements: {average}");
        }
    }
}
