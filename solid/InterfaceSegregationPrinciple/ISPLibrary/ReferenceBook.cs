namespace ISPLibrary
{
    public class ReferenceBook : ILibraryItem
    {
        public string LibraryId { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public int Pages { get; set; }
        public string Title { get; set; } = string.Empty;

        // useless in reference book
        public DateTime BorrowDate { get; set; }
        public string Borrower { get; set; } = string.Empty;
        public int CheckOutDurationInDays { get; set; } = 0;

        // useless in reference book
        public void CheckIn()
        {
            throw new NotImplementedException();
        }
        // useless in reference book
        public void Checkout(string borrower)
        {
            throw new NotImplementedException();
        }
        // useless in reference book
        public DateTime GetDueDate()
        {
            throw new NotImplementedException();
        }
    }
}

