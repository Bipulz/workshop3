namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var ops = new Operators();

            int a = 25;
            int b = 18;
            int num = 88;

            Console.WriteLine($"Sum is: {ops.Add(a , b)}");
            Console.WriteLine($"Difference is: {ops.Subtract(a, b)}");
            Console.WriteLine($"Product is: {ops.Multiply(a , b)}");
            Console.WriteLine($"Divide: {ops.Divide(a, b)}");

            ops.EvenOddFinder(num);
        }
    }
}
