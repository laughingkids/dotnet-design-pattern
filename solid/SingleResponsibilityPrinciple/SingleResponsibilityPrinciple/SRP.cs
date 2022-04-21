namespace SingleResponsibilityPrinciple
{
	public class SRP
	{
		public static void Run()
		{
            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonDataValidator.Validate(user);

            // Checks to be sure to first and last names are valid
            if (!isUserValid)
            {
                StandardMessages.EndApplication();
                return;
            }

            AccountGenerator.CreateAccount(user);

            StandardMessages.EndApplication();
        }
	}
}

