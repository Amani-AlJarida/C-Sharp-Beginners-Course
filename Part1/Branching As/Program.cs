using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initial greeting requirement
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user for package weight
            Console.WriteLine("Please enter the package weight:");
            float weight = float.Parse(Console.ReadLine());

            // Check if weight exceeds the maximum limit of 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                // End program if too heavy
                return;
            }

            // Prompt user for dimensions
            Console.WriteLine("Please enter the package width:");
            float width = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            float length = float.Parse(Console.ReadLine());

            // Calculate the total of the dimensions to check for size limits
            float dimensionTotal = width + height + length;

            // Check if total dimensions exceed 50
            if (dimensionTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                // End program if too big
                return;
            }

            /* 
               Calculation Logic:
               1. Multiply dimensions (Width * Height * Length)
               2. Multiply that result by the weight
               3. Divide the final product by 100 to get the quote
            */
            float quote = (width * height * length * weight) / 100;

            // Display the final quote formatted as a dollar amount
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
            
            // Keep console window open
            Console.ReadLine();
        }
    }
}
