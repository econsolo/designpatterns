namespace ChainOfResponsibility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var h1 = new ConcreteHandler1();
            var h2 = new ConcreteHandler2();
            var h3 = new ConcreteHandler3();

            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            var requests = new int[] { 2, 5, 24, 22, 18, 3, 27, 20 };

            foreach (var request in requests)
            {
                h1.HandleRequest(request);
            }
        }
    }
}