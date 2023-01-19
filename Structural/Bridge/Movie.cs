namespace Bridge
{
    public class Movie : IChannel
    {
        public string Channel()
        {
            return "Tuned in: Movie Channel.";
        }

        public string Status()
        {
            return "You are watching: The Avengers.";
        }
    }
}
