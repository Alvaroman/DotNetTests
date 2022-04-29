namespace Course_Project
{
    public class Stack<T> : IStack<T>
    {
        private readonly List<T> _stacks = new List<T>();
        public int Count => _stacks.Count;

        public T Get(int index) => _stacks[index];

        public T Save(T value)
        {
            _stacks.Add(value);
            return value;
        }
    }
}
