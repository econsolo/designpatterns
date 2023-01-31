namespace TemplateMethod
{
    public class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine($"{nameof(ConcreteClassB)}.{nameof(PrimitiveOperation1)}()");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine($"{nameof(ConcreteClassB)}.{nameof(PrimitiveOperation2)}()");
        }
    }
}
