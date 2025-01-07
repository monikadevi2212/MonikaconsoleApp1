using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonikaConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display the welcome message to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user to enter the weight of the package
            Console.Write("Please enter the package weight: ");
            double weight = double.Parse(Console.ReadLine()); // Read the user's input and convert it to a double

            // Check if the package weight is greater than 50
            if (weight > 50)
            {
                // If the weight exceeds 50, show an error message and end the program
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Exit the program
            }

            // Prompt the user to enter the package width
            Console.Write("Please enter the package width: ");
            double width = double.Parse(Console.ReadLine()); // Read the user's input and convert it to a double

            // Prompt the user to enter the package height
            Console.Write("Please enter the package height: ");
            double height = double.Parse(Console.ReadLine()); // Read the user's input and convert it to a double

            // Prompt the user to enter the package length
            Console.Write("Please enter the package length: ");
            double length = double.Parse(Console.ReadLine()); // Read the user's input and convert it to a double

            // Check if the total of width, height, and length exceeds 50
            if (width + height + length > 50)
            {
                // If the total dimensions exceed 50, show an error message and end the program
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Exit the program
            }

            // Calculate the shipping quote
            // Multiply the width, height, and length to get the volume
            double volume = width * height * length;

            // Multiply the volume by the weight to get the shipping factor
            double shippingFactor = volume * weight;

            // Divide the shipping factor by 100 to get the final quote
            double quote = shippingFactor / 100;

            // Display the calculated shipping quote to the user, formatted as a dollar amount
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

            // Thank the user for using the service
            Console.WriteLine("Thank you!");
        }
    }
}
    

