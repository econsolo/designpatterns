namespace Bridge
{
    public class SmartTv
    {
        public IChannel CurrentChannel { get; set; }

        public void ShowTunedChannel()
        {
            if (CurrentChannel is null)
            {
                Console.WriteLine("Please, select a channel first!");
                return;
            }

            Console.WriteLine(CurrentChannel.Channel());
        }

        public void Play()
        {
            if (CurrentChannel is null)
            {
                Console.WriteLine("Please, select a channel first!");
                return;
            }

            Console.WriteLine(CurrentChannel.Status());
        }
    }
}
