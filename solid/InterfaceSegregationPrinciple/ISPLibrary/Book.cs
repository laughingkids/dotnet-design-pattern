namespace ISPLibrary
{
	public class Book: ILibraryItem
	{
        public string LibraryId { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public DateTime BorrowDate { get; set; }
        public string Borrower { get; set; } = string.Empty;
        public int CheckOutDurationInDays { get; set; } = 14;
        public int Pages { get; set; }
        public string Title { get; set; } = string.Empty;

        public void CheckIn()
        {
            Borrower = "";
        }

        public void Checkout(string borrower)
        {
            Borrower = borrower;
            BorrowDate = DateTime.Now;
        }

        public DateTime GetDueDate()
        {
            return BorrowDate.AddDays(CheckOutDurationInDays);
        }
    }
}

