namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from task5");

            Console.Write("Enter any positive number: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            int total = 0;

            for (int i = 1; i <= limit; i++)
            {
                total += i;
            }
            Console.WriteLine($"Total sum from 1 to {limit} is: {total}");

            int count = 1;
            while (count <= 20)
            {
                // Skip multiples of 5
                if (count % 5 == 0)
                {
                    count++;
                    continue;
                }

                // Stop when count reaches 18
                if (count == 18)
                {
                    break;
                }

                Console.WriteLine(count);
                count++;
            }
        }
    }
}
