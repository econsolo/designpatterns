namespace Strategy
{
    public class SortedList
    {
        private List<string> _list;
        private SortStrategy _sortStrategy;

        public SortedList()
        {
            _list = new();
        }

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortStrategy.Sort(_list);

            foreach (var name in _list)
            {
                Console.WriteLine($" {name}");
            }

            Console.WriteLine();
        }
    }
}
