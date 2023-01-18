namespace Singleton
{
    public class Ball
    {
        public Ball(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
