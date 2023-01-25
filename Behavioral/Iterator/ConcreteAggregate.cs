using System.Collections;

namespace Iterator
{
    public class ConcreteAggregate : Aggregate
    {
        private ArrayList _items = new();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get => _items.Count;
        }

        public object this[int index]
        {
            get => _items[index];
            set => _items.Insert(index, value);
        }
    }
}
