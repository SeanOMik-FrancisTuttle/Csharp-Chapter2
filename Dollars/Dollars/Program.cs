using System;

namespace Dollars {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter amount: ");
            int dollar = Convert.ToInt32(Console.ReadLine());

            String output = "";

            output += (dollar / 20) + " 20s ";
            dollar %= 20;

            output += (dollar / 10) + " 10s ";
            dollar %= 10;

            output += (dollar / 5) + " 5s ";
            dollar %= 5;

            output += (dollar / 1) + " 1s";

            Console.WriteLine(output);
        }
    }
}
