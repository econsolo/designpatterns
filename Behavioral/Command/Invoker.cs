namespace Command
{
    public class Invoker
    {
        private Command _command;

        public Invoker(ConcreteCommand command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }
}
