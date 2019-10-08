using System;

namespace Eggs {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Chicken 1 Egg Monthly Egg Production: ");
            int eggs1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chicken 2 Egg Monthly Egg Production: ");
            int eggs2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chicken 3 Egg Monthly Egg Production: ");
            int eggs3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chicken 4 Egg Monthly Egg Production: ");
            int eggs4 = Convert.ToInt32(Console.ReadLine());

            int eggs = eggs1 + eggs2 + eggs3 + eggs4;
            String eggString = "";
            if (eggs >= 12) {
                int eggDozen = eggs / 12;
                int egg = eggs % 12;

                if (egg > 0) {
                    eggString = eggDozen + " dozen and " + egg + " eggs.";
                } else {
                    eggString = eggDozen + " dozen.";
                }
            }

            Console.WriteLine(eggString);
        }
    }
}
