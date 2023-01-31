namespace Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var students = new SortedList();
            students.Add("Hosea");
            students.Add("Dutch");
            students.Add("Shady");
            students.Add("Arthur");
            students.Add("Lenny");

            students.SetSortStrategy(new QuickSort());
            students.Sort();

            students.SetSortStrategy(new ShellSort());
            students.Sort();

            students.SetSortStrategy(new MergeSort());
            students.Sort();
        }
    }
}