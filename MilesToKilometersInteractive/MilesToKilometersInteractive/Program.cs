using System;

namespace MilesToKilometersInteractive {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Input Amount of Miles: ");
            String milesStr = Console.ReadLine();
            double miles = Convert.ToDouble(milesStr);
            miles *= 1.609344;
            Console.WriteLine(miles + " kilometers");
        }
    }
}
