namespace ChainOfResponsibility
{
    internal class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine($"{GetType().Name} handled request {request}");
                return;
            }

            Successor?.HandleRequest(request);
        }
    }
}
