namespace LibraryFollowISP.Book
{
    public class ReferenceBook : IBook
    {
        public string Author { get; set; } = string.Empty;
        public string LibraryId { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public int Pages { get; set; }
    }
}

