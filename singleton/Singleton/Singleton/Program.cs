namespace Singleton
{
    class Program
    {
        static SingletonTableServers host1List = SingletonTableServers.GetSingletonTableServers();
        static SingletonTableServers host2List = SingletonTableServers.GetSingletonTableServers();

        static void Main(string[] args)
        {
            //TableServers server = new TableServers();
            for (int i = 0; i < 5; i++)
            {
                Host1GetNextServer(); // return _instance
                Host2GetNextServer(); // return same _instance
            }
            Console.ReadLine();
        }

        private static void Host1GetNextServer()
        {
            Console.WriteLine($"The next server in Host1GetNextServer is: {host1List.GetNextServer()}");
        }

        private static void Host2GetNextServer()
        {
            Console.WriteLine($"The next server in Host2GetNextServer is: {host2List.GetNextServer()}");
        }
    }
}