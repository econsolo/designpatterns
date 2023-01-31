namespace Visitor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var objStructure = new ObjectStructure();
            objStructure.Attach(new ConcreteElementA());
            objStructure.Attach(new ConcreteElementB());

            var concreteVisitor1 = new ConcreteVisitor1();
            var concreteVisitor2 = new ConcreteVisitor2();

            objStructure.Accept(concreteVisitor1);
            objStructure.Accept(concreteVisitor2);
        }
    }
}