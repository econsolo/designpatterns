namespace Memento
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var originator = new Originator
            {
                State = "Online"
            };

            var caretaker = new Caretaker
            {
                Memento = originator.CreateMemento()
            };

            originator.State = "Offline";

            originator.SetMemento(caretaker.Memento);
        }
    }
}