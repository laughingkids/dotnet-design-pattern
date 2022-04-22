using LibraryFollowISP.CommonInterfaces;

namespace LibraryFollowISP.Book
{
	public interface IBook : ILibraryItem
	{
        string Author { get; set; }
        int Pages { get; set; }
    }
}

