using System.Xml.Linq;

namespace FunctionAssigmentV1
{
    internal class Program
    {
        static string kysynimi() ///Kysytään nimeä, tässä en saanut auki kommentti templatea.
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
        /// <summary>
        /// Kysytään ikää ja varmistetaan että on positiivinen kokonaisluku.
        /// </summary>
        /// <returns></returns>
        static int kysyika()
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
        /// <summary>
        /// Tulostetaan nimi ja ikä molemmat
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        static void tulostanimiika(string name, int age)
        {
            Console.WriteLine($"Your name is {name} and your age is {age}.");
        }
        /// <summary>
        /// Tarkitetaan onko käyttäjän syöttämä syöte lukuna yli 18
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        static bool Tarkistaonkotaysiikainen (int age)
        {
            if (age >= 18)
                Console.WriteLine("You are an adult.");
            else
                Console.WriteLine("You are not an adult.");
            return false;
        }
        /// <summary>
        /// Verrataan nimeä
        /// </summary>
        /// <param name="name"></param>
        static void vertainimi(string name)
        {
            string compareName = "Matti";
            if (name.Equals(compareName, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Your name matches 'Matti' (case-insensitive).");
            if (name.Equals(compareName))
                Console.WriteLine("Your name is exactly 'Matti' (case-sensitive).");
        }
        /// <summary>
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Everything is intentionally inside Main before refactoring to functions
            //Your job is to refactor this code to use functions for better readability and reusability.
            //Check learn on how to do this




            // Ask for name and ensure it is not empty

            string name = kysynimi();
            // Ask for age and ensure it is a positive integer
            int age = kysyika();

            // Print name and age
            tulostanimiika(name, age);

            // Check if the user is an adult
            Tarkistaonkotaysiikainen(age);

            // Compare the name to another string (e.g., "Matti")
            vertainimi(name);

            // Comparison ignoring case
            

            // Exact match comparison (case-sensitive)
            
        }
    }
}