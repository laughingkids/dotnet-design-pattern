namespace ISPLibrary
{
    public class DVD : ILibraryItem
    {
        public string Title { get; set; } = string.Empty;
        public DateTime BorrowDate { get; set; }
        public string Borrower { get; set; } = string.Empty;
        public int CheckOutDurationInDays { get; set; }
        public string LibraryId { get; set; } = string.Empty;
        // useless in DVD
        public int Pages { get; set; } = -1;
        public string Author { get; set; } = string.Empty;
        // new in DVD
        public List<string>? Actors { get; set; } 
        public int RuntimeInMinutes { get; set; }


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

