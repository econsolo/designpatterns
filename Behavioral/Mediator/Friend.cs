namespace Mediator
{
    public abstract class Friend
    {
        protected Mediator Mediator;

        protected Friend(Mediator mediator)
        {
            Mediator = mediator;
        }
    }
}
