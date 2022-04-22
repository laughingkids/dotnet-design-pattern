using System;
namespace NonDIPLibrary
{
	public class Logger
	{
        public void Log(string message)
        {
            Console.WriteLine($"Write to console: { message }");
        }
    }
}

