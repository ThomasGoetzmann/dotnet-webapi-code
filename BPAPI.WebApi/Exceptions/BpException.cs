namespace BPAPI.WebApi.Exceptions;

public class BpException : Exception
{
    public BpException(string? message, string? operationType) : base(message)
    {
        OperationType = operationType;
    }

    public string? OperationType { get; private set; }
}