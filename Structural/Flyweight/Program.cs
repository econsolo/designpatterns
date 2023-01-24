namespace Flyweight
{
    public class Program
    {
        public static void Main(string[] args)
        {

            FlyweightFactory factory = new FlyweightFactory();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Which turtle?");

                var color = Console.ReadLine();

                var turtle = factory.GetTurtle(color);

                turtle.Show();

                Console.WriteLine();
                Console.WriteLine("----------");
            }
        }
    }
}