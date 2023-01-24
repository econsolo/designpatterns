namespace Flyweight
{
    public class OrangeTurtle : Turtle
    {
        public OrangeTurtle()
        {
            Color = "orange";
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
