
namespace Personal.Patterns.Command
{
    public class CommandA : ICommand
    {
        private readonly Receiver _receiver;
        private readonly string _log;

        public CommandA(Receiver receiver, string log)
        {
            _receiver = receiver;
            _log = log;
        }

        public void Execute()
        {
            _receiver.PrintLog(_log);
        }
    }
}