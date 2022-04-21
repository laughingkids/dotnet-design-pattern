using System;
namespace SingleResponsibilityPrinciple
{
	public class PersonDataValidator
	{
		public static bool Validate(Person person)
		{
            // Checks to be sure to first and last names are valid
            if (string.IsNullOrWhiteSpace(person.FristName))
            {
                StandardMessages.InvalidUserError("first name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessages.InvalidUserError("last name");
                return false;
            }

            return true;
        }
	}
}

