namespace Command
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var receiver = new Receiver();
            var command = new ConcreteCommand(receiver);

            var invoker = new Invoker(command);
            invoker.ExecuteCommand();
        }
    }
}