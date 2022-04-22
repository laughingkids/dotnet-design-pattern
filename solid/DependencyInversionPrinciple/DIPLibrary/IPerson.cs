namespace DIPLibrary
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string TelephoneNumber { get; set; }
        string EmailAddress { get; set; }
    }
}