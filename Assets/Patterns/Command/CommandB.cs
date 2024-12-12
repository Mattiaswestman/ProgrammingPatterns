
namespace Personal.Patterns.Command
{
    public class CommandB : ICommand
    {
        private readonly Receiver _receiver;

        public CommandB(Receiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.PrintLog("Pressed jump key.");
        }
    }
}