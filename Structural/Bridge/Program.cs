namespace Bridge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Select a channel: ");

            Console.WriteLine("1 - Movies");
            Console.WriteLine("2 - Documentary");
            Console.WriteLine("3 - Cooking");

            var smartTv = new SmartTv();

            var input = Console.ReadKey();

            switch (input.KeyChar)
            {
                case '1':
                    smartTv.CurrentChannel = new Movie();
                    break;
                case '2':
                    smartTv.CurrentChannel = new Documentary();
                    break;
                case '3':
                    smartTv.CurrentChannel = new Cooking();
                    break;
            }

            Console.WriteLine();

            smartTv.ShowTunedChannel();
            smartTv.Play();
        }
    }
}