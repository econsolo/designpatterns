namespace Bridge
{
    public class Cooking : IChannel
    {
        public string Channel()
        {
            return "Tuned in: Cooking Channel.";
        }

        public string Status()
        {
            return "You are watching: How to make a delicious cake.";
        }
    }
}
