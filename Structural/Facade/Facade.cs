namespace Facade
{
    public class Facade
    {
        private SubsystemOne One;
        private SubsystemTwo Two;
        private SubsystemThree Three;

        public Facade()
        {
            One = new();
            Two = new();
            Three = new();
        }

        public void MethodA()
        {
            Console.WriteLine("MethodA() -----");
            Two.MethodTwo();
            Three.MethodThree();
        }

        public void MethodB()
        {
            Console.WriteLine("MethodB() -----");
            One.MethodOne();
            Three.MethodThree();
        }
    }
}
