using System.Runtime.Serialization;

[Serializable]
internal class nvalidOperrator : Exception
{
    public nvalidOperrator()
    {
    }

    public nvalidOperrator(string? message) : base(message)
    {
    }

    public nvalidOperrator(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected nvalidOperrator(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}