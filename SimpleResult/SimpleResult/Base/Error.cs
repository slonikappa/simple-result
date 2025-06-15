namespace SimpleResult.Base;

public record Error(string Message, string? Code = null)
{
    public static Error Create(string message, string? code = null)
    {
        if (string.IsNullOrWhiteSpace(message))
        {
            throw new ArgumentException("Error message cannot be null, empty or whitespace.", nameof(message));
        }
        
        return new Error(message, code);
    }
}