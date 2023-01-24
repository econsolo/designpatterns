namespace Flyweight
{
    public class RedTurtle : Turtle
    {
        public RedTurtle()
        {
            Color = "red";
        }

        public override void Show()
        {
            Console.Write(Condition);
            Console.Write(", ");
            Console.Write(Action);
            Console.Write(" and ");
            Console.Write(Color.ToUpper());
        }
    }
}
