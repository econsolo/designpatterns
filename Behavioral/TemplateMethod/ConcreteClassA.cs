namespace TemplateMethod
{
    public class ConcreteClassA : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine($"{nameof(ConcreteClassA)}.{nameof(PrimitiveOperation1)}()");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine($"{nameof(ConcreteClassA)}.{nameof(PrimitiveOperation2)}()");
        }
    }
}
