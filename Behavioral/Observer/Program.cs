namespace Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var subject = new SubjectConcrete();
            subject.Attach(new ObserverConcrete(subject, "A"));
            subject.Attach(new ObserverConcrete(subject, "B"));
            subject.Attach(new ObserverConcrete(subject, "C"));

            subject.State = "ABC";
            subject.Notify();
        }
    }
}