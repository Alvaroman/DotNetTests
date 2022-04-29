using System.Runtime.Serialization;

namespace Course_Project.Exceptions;
[System.Serializable]
public class NotANumberException : GeneralException
{
    public NotANumberException()
    {
    }

    public NotANumberException(string? message) : base(message)
    {
    }

    public NotANumberException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NotANumberException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
