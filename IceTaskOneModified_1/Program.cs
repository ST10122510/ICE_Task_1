using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTaskOneModified_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define constants for egg prices
            const double DOZEN_PRICE = 3.25;
            const double SINGLE_PRICE = 0.45;

            // Initialize a loop variable
            string userInput = "";

            // Loop until the user enters "terminate"
            while (userInput != "terminate")
            {
                // Get the customer's first and last name
                Console.Write("Enter your first name: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter your last name: ");
                string lastName = Console.ReadLine();

                // Get the type and quantity of eggs to order from the user
                Console.Write("Enter the type of eggs to order (dozen or single): ");
                string eggType = Console.ReadLine().ToLower();
                Console.Write("Enter the number of eggs to order: ");
                int eggCount = int.Parse(Console.ReadLine());

                // Calculate the total cost
                int dozenCount = 0;
                int singleCount = 0;
                double totalCost = 0;
                if (eggType == "dozen")
                {
                    dozenCount = eggCount;
                    totalCost = eggCount * DOZEN_PRICE;
                }
                else if (eggType == "single")
                {
                    dozenCount = eggCount / 12;
                    singleCount = eggCount % 12;
                    totalCost = (dozenCount * DOZEN_PRICE) + (singleCount * SINGLE_PRICE);
                }

                // Display the amount owed with a full explanation
                Console.WriteLine("Name: {0} {1}", firstName, lastName);
                Console.WriteLine("Type of eggs: {0}", eggType);
                Console.WriteLine("Number of eggs: {0}", eggCount);
                Console.WriteLine("{0} dozen at ${1:0.00} per dozen: ${2:0.00}", dozenCount, DOZEN_PRICE, dozenCount * DOZEN_PRICE);
                Console.WriteLine("{0} single eggs at ${1:0.00} each: ${2:0.00}", singleCount, SINGLE_PRICE, singleCount * SINGLE_PRICE);
                Console.WriteLine("Total amount owed: ${0:0.00}", totalCost);

                // Prompt the user to continue or terminate the program
                Console.Write("Enter 'terminate' to end the program, or press Enter to continue: ");
                userInput = Console.ReadLine().ToLower();
                Console.WriteLine();
            }
        }
    }
}
