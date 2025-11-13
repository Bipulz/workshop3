namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from task4");

            Console.Write("Enter month number (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());

            string monthName = month switch
            {
                1 => "January",
                2 => "February",
                3 => "March",
                4 => "April",
                5 => "May",
                6 => "June",
                7 => "July",
                8 => "August",
                9 => "September",
                10 => "October",
                11 => "November",
                12 => "December",
                _ => "Invalid month number"
            };

            Console.WriteLine($"Month is: {monthName}");
        }
    }
}
