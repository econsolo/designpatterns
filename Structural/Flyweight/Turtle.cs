namespace Flyweight
{
    public abstract class Turtle
    {
        protected Turtle()
        {
            Condition = "Turtle inside the shell";
            Action = "Spinning on the floor";
        }

        // intrinsic properties
        protected string Condition;
        protected string Action;

        // extrinsic property
        public string Color { get; set; }

        public abstract void Show();
    }
}
