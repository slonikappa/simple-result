namespace SimpleResult.Base;

public abstract class ResultBase(bool isSuccess, Error? error = null)
{
    public bool IsSuccess { get; } = isSuccess;
    
    public bool IsFailure => !IsSuccess;
    
    public Error? Error { get; } = error;
}