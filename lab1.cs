using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            Calculate();
            
        }
        public static void Calculate()
        {
            //inputs
            Console.WriteLine("Please Enter Length:");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Width");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Height");
            double height = double.Parse(Console.ReadLine());

            //math
            double area = length * width;
            double perimeter = (2 * length) + (2 * width);
            double volume = area * height;

            //outputs
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);
            Console.WriteLine("Volume: " + volume);

            //repeat
            Console.WriteLine("Continue? (y/n)");
            char again = char.Parse(Console.ReadLine().ToUpper());
            Console.WriteLine(again);
            if (again.Equals(Char.Parse("Y")))
            {
                Calculate();
            }
        }
    }
}
