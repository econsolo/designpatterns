namespace Visitor
{
    public class ObjectStructure
    {
        private List<Element> _elements;

        public ObjectStructure()
        {
            _elements = new();
        }

        public void Attach(Element element)
        {
            _elements.Add(element);
        }

        public void Detach(Element element)
        {
            _elements.Remove(element);
        }

        public void Accept(Visitor visitor)
        {
            foreach (var element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
