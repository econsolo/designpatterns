namespace Observer
{
    public class ObserverConcrete : Observer
    {
        private string _name;
        private string _state;
        private SubjectConcrete _subject;
        public SubjectConcrete Subject { get; set; }

        public ObserverConcrete(SubjectConcrete subject, string name)
        {
            _subject = subject;
            _name = name;
        }

        public override void Update()
        {
            _state = _subject.State;
            Console.WriteLine($"Observer {_name} your new state is: {_state}");
        }
    }
}
