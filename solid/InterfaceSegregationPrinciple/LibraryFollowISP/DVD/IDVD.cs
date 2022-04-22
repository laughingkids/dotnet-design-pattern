using LibraryFollowISP.CommonInterfaces;
namespace LibraryFollowISP.DVD
{
	public interface IDVD : ILibraryItem
	{
		List<string>? Actors { get; set; }
		int RuntimeInMinutes { get; set; }
	}
}

