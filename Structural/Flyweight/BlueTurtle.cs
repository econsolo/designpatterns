namespace Flyweight
{
    public class BlueTurtle : Turtle
    {
        public BlueTurtle()
        {
            Color = "blue";
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
