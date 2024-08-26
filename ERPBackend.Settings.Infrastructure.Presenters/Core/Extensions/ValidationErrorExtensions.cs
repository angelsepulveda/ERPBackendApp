namespace ERPBackend.Settings.Infrastructure.Presenters.Core.Extensions;

internal static class ValidationErrorExtensions
{
    public static ProblemDetails ToProblemDetails(this IEnumerable<ValidationError> errors, string title, string detail,
        string instance)
    {
        ProblemDetails problemDetails = new();

        problemDetails.Title = title;
        problemDetails.Detail = detail;
        problemDetails.Instance = $"{nameof(problemDetails)}/{instance}";
        problemDetails.Extensions.Add("errors", errors);
        
        return problemDetails;
    }
}