using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTaskOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define constants for egg prices
            const double DOZEN_PRICE = 3.25;
            const double SINGLE_PRICE = 0.45;

            // Get the number of eggs to order from the user
            Console.Write("Enter the number of eggs to order: ");
            int eggCount = int.Parse(Console.ReadLine());

            // Calculate the total cost
            int dozenCount = eggCount / 12;
            int singleCount = eggCount % 12;
            double totalCost = (dozenCount * DOZEN_PRICE) + (singleCount * SINGLE_PRICE);

            // Display the amount owed with a full explanation
            Console.WriteLine("You ordered {0} eggs:", eggCount);
            Console.WriteLine("{0} dozen at ${1:0.00} per dozen: ${2:0.00}", dozenCount, DOZEN_PRICE, dozenCount * DOZEN_PRICE);
            Console.WriteLine("{0} single eggs at ${1:0.00} each: ${2:0.00}", singleCount, SINGLE_PRICE, singleCount * SINGLE_PRICE);
            Console.WriteLine("Total amount owed: ${0:0.00}", totalCost);

            // Wait for the user to press a key before exiting
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
