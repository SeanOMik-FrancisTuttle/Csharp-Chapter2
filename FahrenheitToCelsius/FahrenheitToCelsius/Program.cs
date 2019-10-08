using System;

namespace FahrenheitToCelsius {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Celsius: " + ((fahrenheit - 32) / 1.8));
        }
    }
}
