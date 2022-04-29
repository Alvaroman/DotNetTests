namespace Course_Project
{
    public interface IStack<T>
    {
        public int Count { get; }
        public T Save(T value);
        public T Get(int index);
    }
}
