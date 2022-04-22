namespace LibraryFollowISP.CommonInterfaces
{
	public interface IBorrowable
	{
        DateTime BorrowDate { get; set; }
        string Borrower { get; set; }
        int CheckOutDurationInDays { get; set; }

        void CheckIn();
        void Checkout(string borrower);
        DateTime GetDueDate();
    }
}

