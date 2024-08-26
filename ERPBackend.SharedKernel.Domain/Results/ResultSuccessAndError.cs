namespace ERPBackend.SharedKernel.Domain.Results;

public class Result<SuccessResultType, ErrorResultType> : Result<ErrorResultType>
{
    public SuccessResultType SuccessValue { get; private set; }

    public Result(SuccessResultType successValue) : base()
    {
        SuccessValue = successValue;
    }

    public Result(ErrorResultType errorValue) : base(errorValue)
    {
    }

    public void HandleResult(Action<SuccessResultType> whenHasSuccessAction, Action<ErrorResultType> whenHasErrorAction)
    {
        if (HasError)
            whenHasErrorAction(ErrorValue);
        else
            whenHasSuccessAction(SuccessValue);
    }
}