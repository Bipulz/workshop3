using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Operators
    {
        public int Add(int a, int b)
        {
            return a + b;


        }

        public int Subtract(int a, int b)
        {
            return a - b;

        }

        public int Multiply(int a, int b)
        {
            
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Denominator cant be zero!");
            }
            return (double)a / b;
        }

        public void EvenOddFinder(int number)
        {
            string result = (number % 2 == 0) ? "this is Even Number" : "this is Odd Number";
            Console.WriteLine(result);
        }

    }
}
