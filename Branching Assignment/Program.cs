using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the opening welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user for package weight
            Console.WriteLine("Please enter the package weight:");
            float weight = float.Parse(Console.ReadLine());

            // Check if weight exceeds the limit of 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                // Use return to end the program early
                return;
            }

            // Prompt user for package dimensions
            Console.WriteLine("Please enter the package width:");
            float width = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            float length = float.Parse(Console.ReadLine());

            // Check if the sum of dimensions exceeds the limit of 50
            if ((width + height + length) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                // Use return to end the program early
                return;
            }

            // Calculate the quote: (Width * Height * Length * Weight) / 100
            float dimensionsProduct = width * height * length;
            float quote = (dimensionsProduct * weight) / 100;

            // Display the final quote formatted as a dollar amount
            // Using "C" in the ToString method formats it to the local currency (e.g., $528.00)
            Console.WriteLine("Your estimated total for shipping this package is: " + quote.ToString("C"));
            Console.WriteLine("Thank you!");
            
            // Keep console open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
