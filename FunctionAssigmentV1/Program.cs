using System.Xml.Linq;

namespace FunctionAssigmentV1
{
    internal class Program
    {
        static string kysynimi()
        {
            while (true)
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                    break;
                else
                    Console.WriteLine("Name cannot be empty.");
            }
            return "";
        }
        static string kysyika()
        {
            while (true)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int age) && age > 0)
                    return age;
                    Console.WriteLine("Please enter a positive integer.");
            }
        }
        static void tulostanimiika(string name, int age)
        {

        }
        static bool Tarkistaonkotaysiikainen (int age)
        {
                return false;
        }
        static void vertainimi(string name)
        {

        }
        static void Main(string[] args)
        {
            // Everything is intentionally inside Main before refactoring to functions
            //Your job is to refactor this code to use functions for better readability and reusability.
            //Check learn on how to do this
            string name = kysynimi();
            int age = kysyika();

            // Ask for name and ensure it is not empty


            // Ask for age and ensure it is a positive integer


            // Print name and age
            Console.WriteLine($"Your name is {name} and your age is {age}.");

            // Check if the user is an adult
            if (age >= 18)
                Console.WriteLine("You are an adult.");
            else
                Console.WriteLine("You are not an adult.");

            // Compare the name to another string (e.g., "Matti")
            string compareName = "Matti";

            // Comparison ignoring case
            if (name.Equals(compareName, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Your name matches 'Matti' (case-insensitive).");

            // Exact match comparison (case-sensitive)
            if (name.Equals(compareName))
                Console.WriteLine("Your name is exactly 'Matti' (case-sensitive).");
        }
    }
}