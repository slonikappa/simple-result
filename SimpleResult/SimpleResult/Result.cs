﻿using SimpleResult.Base;

namespace SimpleResult;

public sealed class Result : ResultBase
{
    private Result(bool isSuccess, Error? error = null) : base(isSuccess, error) { }

    public static Result Success() => new(true);
    public static Result Failure(Error error) => new(false, error);
}