using System;
namespace SingleResponsibilityPrinciple
{
	public class StandardMessages
	{
		public static void WelcomeMessage()
        {
			Console.WriteLine("Welcome to my application");
        }

		public static void InvalidUserError(string fieldName)
		{
            Console.WriteLine($"You did not give us a valid { fieldName }");
        }

		public static void EndApplication()
        {
			Console.WriteLine("Press enter to close...");
			Console.ReadLine();
        }
	}
}

