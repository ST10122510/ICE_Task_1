using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoyalityProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string customerFirstName, customerLastName, eggType, orderString;
            int quantity;
            decimal orderTotal;
            decimal dozenPrice = 3.25M;
            decimal singlePrice = 0.45M;
            DateTime currentDate = DateTime.Today;

            // Create or append to the sales file for the current date
            string salesFilePath = $"{currentDate.ToString("yyyy-MM-dd")}-sales.txt";
            StreamWriter salesFile = File.AppendText(salesFilePath);

            Console.WriteLine("Welcome to Meadowdale Dairy Farm!");

            // Loop until user enters "terminate"
            while (true)
            {
                Console.Write("Please enter your first name (or 'terminate' to exit): ");
                customerFirstName = Console.ReadLine().ToLower();

                if (customerFirstName == "terminate")
                {
                    break;
                }

                Console.Write("Please enter your last name: ");
                customerLastName = Console.ReadLine().ToLower();

                Console.Write("What type of eggs would you like? (brown or white): ");
                eggType = Console.ReadLine().ToLower();

                Console.Write("How many eggs would you like to order? ");
                orderString = Console.ReadLine();

                if (!int.TryParse(orderString, out quantity))
                {
                    Console.WriteLine("Invalid quantity entered. Please enter a whole number.");
                    continue;
                }

                if (quantity <= 0)
                {
                    Console.WriteLine("Invalid quantity entered. Please enter a positive number.");
                    continue;
                }

                if (eggType != "brown" && eggType != "white")
                {
                    Console.WriteLine("Invalid egg type entered. Please enter 'brown' or 'white'.");
                    continue;
                }

                // Calculate the order total based on the type of eggs and quantity ordered
                if (quantity >= 12)
                {
                    orderTotal = Math.Round(quantity * dozenPrice, 2);
                }
                else
                {
                    orderTotal = Math.Round(quantity * singlePrice, 2);
                }

                // Add the order to the sales file
                salesFile.WriteLine($"{currentDate.ToString("yyyy-MM-dd")},{customerFirstName},{customerLastName},{eggType},{quantity},{orderTotal}");

                // Display the order total to the user
                Console.WriteLine($"Your total order amount is: ${orderTotal}");
            }

            // Close the sales file
            salesFile.Close();

            Console.WriteLine("Thank you for shopping at Meadowdale Dairy Farm!");
        }
    }
}
