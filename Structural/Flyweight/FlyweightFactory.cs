namespace Flyweight
{
    public class FlyweightFactory
    {
        private Dictionary<string, Turtle> _turtles;

        public FlyweightFactory()
        {
            _turtles = new Dictionary<string, Turtle>();
        }

        public Turtle GetTurtle(string color)
        {
            if (_turtles.TryGetValue(color, out var turtle))
                return turtle;

            turtle = CreateTurtle(color);

            _turtles.Add(color, turtle);

            return turtle;
        }

        private static Turtle? CreateTurtle(string color)
        {
            return color switch
            {
                "blue" => new BlueTurtle(),
                "green" => new GreenTurtle(),
                "red" => new RedTurtle(),
                "orange" => new OrangeTurtle(),
                _ => default,
            };
        }
    }
}
