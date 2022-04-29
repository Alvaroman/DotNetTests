using Course_Project.Exceptions;

namespace Course_Project;
public class MyTest : IMyTest
{
    private const int ONE = 1;
    private readonly IStack<int> _stack;

    public MyTest(IStack<int> stack)
    {
        this._stack = stack;
    }
    public string Value { get; set; }

    public event EventHandler<Guid> Triggered;

    public string CalculateBuzz(int number)
    {
        if (number % 3 == 0 && number % 5 == 0)
        {
            return "FizzBuzz";
        }
        if (number % 3 == 0)
        {
            return "Fizz";
        }
        if (number % 5 == 0)
        {
            return "Buzz";
        }
        return number.ToString();
    }

    public void Event(string info)
    {
        if (String.IsNullOrWhiteSpace(info))
        {
            throw new ArgumentNullException("info");
        }
        Value = info;
        Triggered?.Invoke(this, Guid.NewGuid());
    }

    public int GetNumber() => new Random().Next();

    public bool IsOne(object number)
    {
        if (int.TryParse(number.ToString(), out int parsedNumber))
        {
            return parsedNumber == ONE;
        }
        else
        {
            throw new NotANumberException("Not a number.");
        }
    }
    public int RegisterStack(int number) => _stack.Save(number);

}
