/**
 * Higher level module depends on Lower level module: Logger and Emailer
 **/
namespace DIPLibrary
{
    public class Chore : IChore
    {
        ILogger _logger;
        IMessageSender _messageSender;

        public string ChoreName { get; set; } = String.Empty;
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        public Chore(ILogger logger, IMessageSender messageSender)
        {
            _logger = logger;
            _messageSender = messageSender;
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Performed work on {ChoreName}");
        }

        public void CompleteChore()
        {
            IsComplete = true;
            Logger log = new Logger();
            log.Log($"Completed {ChoreName}");

            _messageSender.SendMessage(Owner, $"The chore {ChoreName} is complete.");
        }
    }
}

