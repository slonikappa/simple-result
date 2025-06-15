using SimpleResult.Base;

namespace SimpleResult;

public sealed class DataResult<T> : ResultBase
    where T : class
{
    public T? Data { get; }

    private DataResult(T data) : base(true) => Data = data;
    private DataResult(Error error) : base(false, error) { }

    public static DataResult<T> Success(T data) => new(data);
    
    public static DataResult<T> Failure(Error error) => new(error);

    public static DataResult<T> Failure(string message, string? code = null) => new(Error.Create(message, code));

    public static implicit operator DataResult<T>(Result result) =>
        result.IsSuccess
            ? throw new InvalidOperationException("Cannot convert successful non-generic result to generic result without data")
            : new DataResult<T>(result.Error!);
}