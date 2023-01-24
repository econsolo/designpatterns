namespace Proxy
{
    public class Proxy : Subject
    {
        private RealSubject _realSubject;

        public override void Request()
        {
            _realSubject ??= new RealSubject();
            _realSubject.Request();
        }
    }
}
