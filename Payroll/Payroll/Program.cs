using System;

namespace Payroll {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();

            Console.Write("Social Security number: ");
            String ssn = Console.ReadLine();

            Console.Write("Hourly pay rate: ");
            double payRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Hours Worked: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            double grossPay = payRate * hours;
            double federalHolding = payRate * 0.15;
            double stateHolding = payRate * 0.05;

            double netPay = grossPay - federalHolding - stateHolding;

            Console.WriteLine("Gross pay:                 " + grossPay.ToString("C"));
            Console.WriteLine("Federal withholding:       " + federalHolding.ToString("C"));
            Console.WriteLine("State withholding:         " + stateHolding.ToString("C"));
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Net pay:                   " + netPay.ToString("C"));
        }
    }
}
