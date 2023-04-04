namespace Demo.Mutation;

public class InvalidOperationException : Exception
{
    public InvalidOperationException() : base("My mutation invalid message.")
    {
    }
}