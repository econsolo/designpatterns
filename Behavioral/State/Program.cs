namespace State
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var context = new Context(new StateConcreteA());

            context.Request();
            context.Request();
            context.Request();
            context.Request();
        }
    }
}