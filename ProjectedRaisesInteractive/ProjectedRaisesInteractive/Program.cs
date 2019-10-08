using System;

namespace ProjectedRaisesInteractive {
    class Program {
        static void Main(string[] args) {
            const double raisePercent = 0.04;
            Console.Write("Employee 1 Salary: ");
            double emp1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Employee 2 Salary: ");
            double emp2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Employee 3 Salary: ");
            double emp3 = Convert.ToDouble(Console.ReadLine());

            emp1 += (emp1 * raisePercent);
            emp2 += (emp2 * raisePercent);
            emp3 += (emp3 * raisePercent);

            Console.WriteLine("Employee 1 Next Year Salary: " + emp1);
            Console.WriteLine("Employee 2 Next Year Salary: " + emp2);
            Console.WriteLine("Employee 3 Next Year Salary: " + emp3);
        }
    }
}
