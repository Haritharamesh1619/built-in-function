using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace built_in_function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value : ");// "WriteLine"is also build in function  used to print the given statment
            int x = int.Parse(Console.ReadLine());
            
            double squareRoot = Math.Sqrt(x);// "sqrt" is a build in function used to give the square value for x
            Console.WriteLine($"Square Root of {x} is {squareRoot}");
            Console.ReadLine();
        }
    }
}
