using System;
namespace SingleResponsibilityPrinciple
{
	public class NonSRP
    {
		public static void Run()
		{
            Console.WriteLine("Welcome to my application!");

            Person user = new Person();

            Console.Write("What is your first name: ");
            user.FristName = Console.ReadLine();

            Console.Write("What is your last name:");
            user.LastName = Console.ReadLine();

            // Checks to be sure to first and last names are valid
            if (string.IsNullOrWhiteSpace(user.FristName))
            {
                Console.WriteLine("You did not give us a valid first name!");
                Console.ReadLine();
                return;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("You did not give us a valid last name!");
                Console.ReadLine();
                return;
            }

            Console.WriteLine($"Your username is {user.FristName.Substring(0, 1)}{user.LastName}");
            Console.ReadLine();
        }
	}
}
