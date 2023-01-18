namespace Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Using Singleton we guarantee that there is only one ball on the field

            var player1 = Singleton.Ball;
            player1.ShowMessage("Player 1: I'm with the ball!");
            
            var player2 = Singleton.Ball;
            player2.ShowMessage("Player 2: I received the ball!");

            var player3 = Singleton.Ball;
            player3.ShowMessage("Player 3: I kicked the ball!");
        }
    }
}