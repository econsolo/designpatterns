namespace Iterator
{
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _concreteAggregate;
        private int _current = 0;

        public ConcreteIterator(ConcreteAggregate concreteAggregate)
        {
            _concreteAggregate = concreteAggregate;
        }

        public override object CurrentItem()
        {
            return _concreteAggregate[_current];
        }

        public override object First()
        {
            return _concreteAggregate[0];
        }

        public override bool IsDone()
        {
            return _current >= _concreteAggregate.Count;
        }

        public override object Next()
        {
            if (_current >= _concreteAggregate.Count - 1)
                return default;

            return _concreteAggregate[++_current];
        }
    }
}
