namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value to convert to double: ");
            try
            {
                string userInput = Console.ReadLine();
                double value = Convert.ToDouble(userInput);
                Console.WriteLine($"You entered: {value}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format! Please enter a numeric value.");
            }
            finally
            {
                Console.WriteLine("Conversion process completed.");
            }

            // PIN check
            Console.Write("Enter a 4-digit PIN: ");
            try
            {
                string pin = Console.ReadLine();

                if (pin.Length != 4)
                {
                    throw new ArgumentException("PIN must contain exactly 4 digits.");
                }
                else
                {
                    Console.WriteLine("PIN accepted successfully!");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
