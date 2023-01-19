namespace Bridge
{
    public class Documentary : IChannel
    {
        public string Channel()
        {
            return "Tuned in: Documentary Channel.";
        }

        public string Status()
        {
            return "You are watching: Chernobyl.";
        }
    }
}
