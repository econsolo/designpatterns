namespace ChainOfResponsibility
{
    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine($"{GetType().Name} handled request {request}");
                return;
            }

            Successor?.HandleRequest(request);
        }
    }
}
