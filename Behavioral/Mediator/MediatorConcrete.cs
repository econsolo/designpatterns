namespace Mediator
{
    public class MediatorConcrete : Mediator
    {
        public FriendConcrete1 _friend1;
        public FriendConcrete2 _friend2;

        public FriendConcrete1 Friend1
        {
            set { _friend1 = value; }
        }

        public FriendConcrete2 Friend2
        {
            set { _friend2 = value; }
        }

        public override void Send(string message, Friend friend)
        {
            if (friend == _friend1)
            {
                _friend2.Notify(message);
            }
            else
            {
                _friend1.Notify(message);
            }
        }
    }
}
