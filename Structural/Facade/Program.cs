namespace Facade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var facade = new Facade();
            facade.MethodA();

            Console.WriteLine();

            facade.MethodB();
        }
    }
}