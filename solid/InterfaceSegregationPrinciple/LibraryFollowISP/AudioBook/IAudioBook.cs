using LibraryFollowISP.CommonInterfaces;

namespace LibraryFollowISP.AudioBook
{
	public interface IAudioBook: ILibraryItem
	{
		int RuntimeInMinutes { get; set; }
	}
}

