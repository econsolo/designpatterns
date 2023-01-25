namespace Mediator
{
    public class FriendConcrete2 : Friend
    {
        public FriendConcrete2(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            Mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"Message to Friend2: {message}");
        }
    }
}
