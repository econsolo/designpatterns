namespace Mediator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var mediatorConcrete = new MediatorConcrete();

            var friendConcrete1 = new FriendConcrete1(mediatorConcrete);
            var friendConcrete2 = new FriendConcrete2(mediatorConcrete);


            mediatorConcrete.Friend1 = friendConcrete1;
            mediatorConcrete.Friend2 = friendConcrete2;

            friendConcrete1.Send("Hey, how are you?");
            friendConcrete2.Send("Fine, thanks!");
        }
    }
}