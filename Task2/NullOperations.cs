using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class NullOperations
    {
        public void PerformNullChecks()
        {
            string? cityName = null;

            string resultTernary = (cityName == null) ? "City name is not provided" : cityName;
            Console.WriteLine("Using Ternary Operator: " + resultTernary);

            string resultCoalescing = cityName ?? "City name is not provided";
            Console.WriteLine("Using Null Coalescing Operator: " + resultCoalescing);

            cityName ??= "Kathmandu";
            Console.WriteLine("Using Null Coalescing Assignment: " + cityName);
        }
    }
}
