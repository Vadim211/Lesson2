using System.IO.Compression;
using System.Text.RegularExpressions;
using static HomeWork2.User;

namespace HomeWork2
{
    class Program()
    {
        public static void Main()
        {
            // First implementation
            User user1 = new(29)
            {
                UserGender = User.Gender.Male
            };

            Console.Write("Enter first name: ");
            user1.FirstName = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter last name: ");
            user1.LastName = Console.ReadLine() ?? string.Empty;

            Console.WriteLine();
            Console.WriteLine("User Information:");
            Console.WriteLine("------------------");
            Console.WriteLine($"| {"First name",-12} | {user1.FirstName,-15} |");
            Console.WriteLine($"| {"Last name",-12} | {user1.LastName,-15} |");
            Console.WriteLine($"| {"Age",-12} | {user1.Age,-15} |");
            Console.WriteLine($"| {"Gender",-12} | {user1.UserGender,-15} |");
            Console.WriteLine("------------------");

            // Second implementation
            User user2 = new();

            var regExp = @"^[A-Za-z]+$";
            string firstName;
            string lastName;
            int age;
            int gender;

            // If it weren't for the first implementation, the code below could have been put
            // into a separate function and reused to avoid code duplication.

            do
            {
                Console.WriteLine("Enter first name:");
                firstName = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrEmpty(firstName))
                {
                    Console.WriteLine("Name should be at least 2 characters");
                }
                else if (!Regex.IsMatch(firstName, regExp))
                {
                    Console.WriteLine("Name should contain only letters");
                }
            } while (firstName == string.Empty || !Regex.IsMatch(firstName, regExp));
            user2.FirstName = firstName;

            do
            {
                Console.WriteLine("Enter last name:");
                lastName = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrEmpty(lastName))
                {
                    Console.WriteLine("Last name should be at least 2 characters");
                }
                else if (!Regex.IsMatch(lastName, regExp))
                {
                    Console.WriteLine("Last name should contain only letters");
                }
            } while (lastName == string.Empty || !Regex.IsMatch(lastName, regExp));
            user2.LastName = lastName;

            do
            {
                Console.Write("Enter your age: ");
                Console.WriteLine();
                if (!int.TryParse(Console.ReadLine(), out age) || age < 0)
                {
                    Console.WriteLine("Invalid age. Age must be a non-negative integer.");
                }
            } while (age < 0);
            user2.Age = age;

            do
            {
                Console.WriteLine("Choose your gender:");
                Console.WriteLine("1. Male\t 2. Female\t 3. Unknown");
                Console.Write("Your choice: ");
                if (!int.TryParse(Console.ReadLine(), out gender) || gender < 1 || gender > 3)
                {
                    Console.WriteLine("Please choose 1, 2, or 3.");
                }
            } while (gender < 1 || gender > 3);

            user2.UserGender = (User.Gender)(gender - 1);

            Console.WriteLine(user2.ToString());
        }
    }
}