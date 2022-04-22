namespace ISPLibrary
{
    public class AudioBook : ILibraryItem
    {
        public string Author { get; set; } = String.Empty;
        public DateTime BorrowDate { get; set; }
        public string Borrower { get; set; } = String.Empty;
        public int CheckOutDurationInDays { get; set; } = 14;
        public string LibraryId { get; set; } = String.Empty;
        public int Pages { get; set; } = -1;
        public string Title { get; set; } = String.Empty;
        // new in audio book
        public int RuntimeInMinutes { get; set; } = 0;

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

