namespace Singleton
{
	public class TableServers
	{
		private List<string> servers = new List<string>();
		private int nextServer = 0;

		public TableServers()
        {
			servers.Add("test-1");
			servers.Add("test-2");
			servers.Add("test-3");
			servers.Add("test-4");
		}

		public string GetNextServer()
        {
			string output = servers[nextServer];
			nextServer += 1;
			if(nextServer >= servers.Count)
            {
				nextServer = 0;
            }
			return output;
        }
	}
}

