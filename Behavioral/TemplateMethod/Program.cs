namespace TemplateMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var absClassA = new ConcreteClassA();
            absClassA.TemplateMethod();

            var absClassB = new ConcreteClassB();
            absClassB.TemplateMethod();
        }
    }
}