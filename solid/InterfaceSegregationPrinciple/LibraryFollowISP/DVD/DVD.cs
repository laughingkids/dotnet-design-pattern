namespace LibraryFollowISP.DVD
{
    public class DVD : IBorrowableDVD
    {
        public DateTime BorrowDate { get; set; }
        public string Borrower { get; set; } = string.Empty;
        public int CheckOutDurationInDays { get; set; }
        public string LibraryId { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
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

