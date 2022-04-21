using System;
namespace SingleResponsibilityPrinciple
{
	public class AccountGenerator
	{
		public static void CreateAccount(Person user)
        {
			string userName = GeneratorUserName(user);
			Console.WriteLine($"Your username is {userName}");
		}

		public static string GeneratorUserName(Person user)
        {
			return $"{ user.FristName.Substring(0, 1) }{ user.LastName }";
        }
	}
}

