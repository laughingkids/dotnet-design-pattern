namespace Singleton
{
	public class SingletonTableServers
	{
		private static readonly SingletonTableServers _instance = new SingletonTableServers();
		private List<string> servers = new List<string>();
		private int nextServer = 0;

		private SingletonTableServers()
		{
			servers.Add("singleton server 1");
			servers.Add("singleton server 2");
			servers.Add("singleton server 3");
			servers.Add("singleton server 4");
		}

		public static SingletonTableServers GetSingletonTableServers()
        {
			return _instance;
        }

		public string GetNextServer()
		{
			string output = servers[nextServer];
			nextServer += 1;
			if (nextServer >= servers.Count)
			{
				nextServer = 0;
			}
			return output;
		}
	}
}

