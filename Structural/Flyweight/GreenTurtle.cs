namespace Flyweight
{
    public class GreenTurtle : Turtle
    {
        public GreenTurtle()
        {
            Color = "green";
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
