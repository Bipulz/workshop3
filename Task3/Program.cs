namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from task3");

            Console.Write("Enter your score: ");
            int score = Convert.ToInt32(Console.ReadLine());

            if (score < 0)
            {
                throw new ArgumentOutOfRangeException("Score cannot be negative");
            }
            else if (score < 40)
            {
                Console.WriteLine("Fail");
            }
            else if (score >= 40 && score <= 59)
            {
                Console.WriteLine("Average");
            }
            else if (score >= 60 && score <= 79)
            {
                Console.WriteLine("Good");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Excellent");
            }
            else
            {
                Console.WriteLine("Unexpected input!");
            }
        }
    }
}
