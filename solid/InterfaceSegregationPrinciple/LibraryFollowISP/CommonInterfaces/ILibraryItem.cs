using LibraryFollowISP.CommonInterfaces;

namespace LibraryFollowISP.CommonInterfaces
{
    public interface ILibraryItem
    {
        string LibraryId { get; set; }
        string Title { get; set; }
    }
}

