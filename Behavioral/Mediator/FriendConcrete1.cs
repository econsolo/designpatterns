namespace Mediator
{
    public class FriendConcrete1 : Friend
    {
        public FriendConcrete1(Mediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            Mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"Message to Friend1: {message}");
        }
    }
}
