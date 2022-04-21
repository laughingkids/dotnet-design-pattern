using System;
namespace SingleResponsibilityPrinciple
{
	public class PersonDataCapture
	{
		public static Person Capture()
        {
            Person user = new Person();

            Console.Write("What is your first name: ");
            user.FristName = Console.ReadLine();

            Console.Write("What is your last name:");
            user.LastName = Console.ReadLine();

            return user;
        }
	}
}

